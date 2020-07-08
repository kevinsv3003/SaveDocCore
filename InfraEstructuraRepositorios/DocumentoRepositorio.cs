using Entidades.Entidades;
using InfraEstructura.Contratos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstructuraRepositorios
{
    public class DocumentoRepositorio : BaseRepositorio<Documento>, IDocumento
    {
        public DocumentoRepositorio(DbContext context) : base(context)
        {

        }
    }
}
