using AutoMapper;
using Dominio.Contratos;
using Dominio.EntidadesDto;
using Entidades.Entidades;
using InfraEstructura.Transversal;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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
                //var usuario = await _userManager.FindByNameAsync(usuariodto.UserName);
                var usuario = await _userManager.FindByIdAsync(usuariodto.Id);

                usuario.Nombres = usuariodto.Nombres;
                usuario.Apellidos = usuariodto.Apellidos;
                usuario.UserName = usuariodto.UserName;
                usuario.FechaNacimiento = usuariodto.FechaNacimiento;
                usuario.Sexo = usuariodto.Sexo;
                usuario.Direccion = usuariodto.Direccion;
                usuario.PhoneNumber = usuariodto.PhoneNumber;
                usuario.Email = usuariodto.Email;
                usuario.Edad = General.ObtenerEdadActual(usuario.FechaNacimiento);
                
                var roles = await obtenerRolUsuario(usuario);
                var borrarRol = (roles != string.Empty) ? await _userManager.RemoveFromRoleAsync(usuario, await obtenerRolUsuario(usuario)) : null;
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
            var tokenResetPass = await _userManager.GeneratePasswordResetTokenAsync(user);
            //var resetPass = await _userManager.AddPasswordAsync(user, contraseña);
            var resetPass = await _userManager.ResetPasswordAsync(user, tokenResetPass, pass);

            return resetPass.Succeeded;
        }

      
    }
}
