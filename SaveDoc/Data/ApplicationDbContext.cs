using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaveDoc.Models;

namespace SaveDoc.Data
{
    public class ApplicationDbContext : IdentityDbContext<UsuarioApp>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
