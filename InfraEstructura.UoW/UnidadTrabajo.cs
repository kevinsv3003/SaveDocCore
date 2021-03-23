using InfraEstructura.AccesoDatos;
using InfraEstructura.Contratos;
using InfraEstructuraRepositorios;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstructura.UoW
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly DocumentoContext documentoContext;
        private readonly IConfiguration _configuration;
        public UnidadTrabajo(DocumentoContext documentoContext, IConfiguration _configuration)
        {
            this.documentoContext = documentoContext;
            this._configuration = _configuration;
        }

        IArea IUnidadTrabajo.AreaRepositorio => new AreaRepositorio(documentoContext);
        IDocumento IUnidadTrabajo.DocumentoRepositorio => new DocumentoRepositorio(documentoContext, _configuration);



        public void commit()
        {
            documentoContext.SaveChanges();
            if (documentoContext.Database.CurrentTransaction != null)
            {
                documentoContext.Database.CurrentTransaction.Commit();
            }
        }

        public void Disposable()
        {
            GC.KeepAlive(this);
            documentoContext.Dispose();
        }

        public void RollBack()
        {
            documentoContext.Database.CurrentTransaction.Rollback();
        }
    }
}
