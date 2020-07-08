using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Contratos;
using Entidades.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SaveDoc.Models;

namespace SaveDoc.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<UsuarioApp> _userManager;
        private IUsuarioNegocio usuarioNegocio;

        public HomeController(UserManager<UsuarioApp> _userManager,IUsuarioNegocio usuarioNegocio)
        {
            this._userManager = _userManager;
            this.usuarioNegocio = usuarioNegocio;
        }

        [Authorize]     
        public async Task<IActionResult> Index()
        {
            var usuario = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(User) : null;
            ViewBag.RolActual = (usuario != null) ? await usuarioNegocio.obtenerRolUsuario(usuario) : "";
            return View();
        }

       
      
    }
}
