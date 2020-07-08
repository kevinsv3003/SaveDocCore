using Entidades.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstructura.AccesoDatos
{
    public class DocumentoContext : DbContext
    {
        public DocumentoContext()
        {

        }

        public DocumentoContext(DbContextOptions<DocumentoContext> options) : base(options)
        {
            try
            {
                //Database.Migrate();
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MiProyectoCoreDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Documento> Documentos { get; set; }
    }
}
