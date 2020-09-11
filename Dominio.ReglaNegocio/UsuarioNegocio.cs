using AutoMapper;
using ClosedXML.Excel;
using Dominio.Contratos;
using Dominio.EntidadesDto;
using Entidades.Entidades;
using InfraEstructura.Transversal;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.ReglaNegocio
{
    public class UsuarioNegocio : IUsuarioNegocio
    {
        private SignInManager<UsuarioApp> _signManager;
        private UserManager<UsuarioApp> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public UsuarioNegocio(SignInManager<UsuarioApp> _signManager, UserManager<UsuarioApp> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            this._signManager = _signManager;
            this._userManager = _userManager;
            this._roleManager = _roleManager;
        }

        public List<UsuarioDto> ObtenerUsuarios()
        {
            var resultado = new List<UsuarioDto>();
            try
            {
                var users = _userManager.Users.ToList();
                foreach (var item in users)
                {
                    var user = Mapper.Map<UsuarioApp, UsuarioDto>(item);
                    user.Rol = obtenerRolUsuario(item).Result;
                    resultado.Add(user);
                }
            }
            catch (Exception ex)
            {
                throw(ex);
            }
            return resultado;
        }

        public async Task<bool> ActualizarUsuario(UsuarioDto usuariodto)
        {
            bool respuesta = false;
            try
            {
                var usuario =  await _userManager.FindByIdAsync(usuariodto.Id);

                usuario.Nombres = usuariodto.Nombres;
                usuario.Apellidos = usuariodto.Apellidos;
                usuario.UserName = usuariodto.UserName;
                usuario.FechaNacimiento = usuariodto.FechaNacimiento;
                usuario.Sexo = usuariodto.Sexo;
                usuario.Direccion = usuariodto.Direccion;
                usuario.PhoneNumber = usuariodto.PhoneNumber;
                usuario.Email = usuariodto.Email;
                usuario.Edad = General.ObtenerEdadActual(usuariodto.FechaNacimiento);
                
                var rolUsuario = await obtenerRolUsuario(usuario);
                var borrarRol = (rolUsuario != string.Empty) ? await _userManager.RemoveFromRoleAsync(usuario, rolUsuario) : null;
                var AsignarRol = (borrarRol.Succeeded) ? await _userManager.AddToRoleAsync(usuario, usuariodto.Rol) : null;
                var Actualizado = await _userManager.UpdateAsync(usuario);

                respuesta = Actualizado.Succeeded && AsignarRol.Succeeded;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return respuesta;
        }

        public async Task<bool> GuardarUsuario(UsuarioDto usuarioDto)
        {
            bool respuesta = false;
            try
            {
                usuarioDto.Edad = General.ObtenerEdadActual(usuarioDto.FechaNacimiento);
                var usuario = Mapper.Map<UsuarioDto, UsuarioApp>(usuarioDto);
                var guardoUsuario = await _userManager.CreateAsync(usuario,usuarioDto.contra);
                var rolAsignado = await _userManager.AddToRoleAsync(usuario, usuarioDto.Rol);

                respuesta = guardoUsuario.Succeeded && rolAsignado.Succeeded;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return respuesta;
        }

        public async Task<bool> EliminarUsuario(string Id)
        {
            bool respuesta = false;
            try
            {
                var usuario = await _userManager.FindByIdAsync(Id);
                var EliminoUsuario = await _userManager.DeleteAsync(usuario);

                respuesta = EliminoUsuario.Succeeded;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return respuesta;
        }

        public async Task<string> obtenerRolUsuario(UsuarioApp usuario)
        {
            var rolList = await _userManager.GetRolesAsync(usuario);
            var rol = rolList.Count > 0 ? new List<string>(rolList).ToArray()[0] : "";
            return rol;
        }

        public async Task<bool> ResetPass(UsuarioApp user, string pass)
        {
            //var removePass = await _userManager.RemovePasswordAsync(user);
            //var resetPass = await _userManager.AddPasswordAsync(user, contraseña);
            var tokenResetPass = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetPass = await _userManager.ResetPasswordAsync(user, tokenResetPass, pass);

            return resetPass.Succeeded;
        }

        public async Task<byte[]> ObtenerUsuariosExcel()
        {
            var usuarios = ObtenerUsuarios();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Usuarios");

                worksheet.Range("B2:I3").Merge().SetValue("LISTADO DE USUARIOS ACTIVOS").Style
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                    .Font.SetBold()
                    .Font.SetFontColor(XLColor.White)
                    .Fill.SetBackgroundColor(XLColor.FromArgb(56, 162, 81));

                worksheet.Cell("B4").Value = "Usuario";
                worksheet.Cell("C4").Value = "Nombre";
                worksheet.Cell("D4").Value = "Apellidos";
                worksheet.Cell("E4").Value = "Correo";
                worksheet.Cell("F4").Value = "Fecha Nacimiento";
                worksheet.Cell("G4").Value = "Sexo";
                worksheet.Cell("H4").Value = "Rol";
                worksheet.Cell("I4").Value = "Direccion";
                worksheet.Range("B4:I4").Style
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    .Border.SetInsideBorder(XLBorderStyleValues.Thin)
                    .Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.AliceBlue);
                worksheet.Range("B4:I4").SetAutoFilter();

                worksheet.Range("B2:I" + (usuarios.Count() + 4).ToString()).Style.Border.SetInsideBorder(XLBorderStyleValues.Thin);
                worksheet.Range("B2:I" + (usuarios.Count() + 4).ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                var currentRow = 4;
                foreach (var user in usuarios)
                {
                    currentRow++;
                    worksheet.Cell("B" + currentRow).Value = user.UserName;
                    worksheet.Cell("C" + currentRow).Value = user.Nombres;
                    worksheet.Cell("D" + currentRow).Value = user.Apellidos;
                    worksheet.Cell("E" + currentRow).Value = user.Email;
                    worksheet.Cell("F" + currentRow).Value = user.FechaNacimiento;
                    worksheet.Cell("G" + currentRow).Value = user.Sexo;
                    worksheet.Cell("H" + currentRow).Value = user.Rol;
                    worksheet.Cell("I" + currentRow).Value = user.Direccion;
                }
                worksheet.Columns(2, 9).AdjustToContents();
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return content;
                }
            }
        }
    }
}
