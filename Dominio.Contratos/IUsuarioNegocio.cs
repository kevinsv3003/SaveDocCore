using Dominio.EntidadesDto;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos
{
    public interface IUsuarioNegocio
    {
        Task<bool> ActualizarUsuario(UsuarioDto usuariodto);
        Task<string> obtenerRolUsuario(UsuarioApp usuario);
        Task<bool> ResetPass(UsuarioApp user, string pass);
        Task<bool> GuardarUsuario(UsuarioDto usuarioDto);
        Task<bool> EliminarUsuario(string Id);
        List<UsuarioDto> ObtenerUsuarios();
        Task<byte[]> ObtenerUsuariosExcel();
    } 
}
