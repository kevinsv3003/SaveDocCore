using InfraEstructura.AccesoDatos;
using InfraEstructura.Contratos;
using InfraEstructuraRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstructura.UoW
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly DocumentoContext documentoContext;

        IArea IUnidadTrabajo.AreaRepositorio => new AreaRepositorio(documentoContext);
        
        IDocumento IUnidadTrabajo.DocumentoRepositorio => new DocumentoRepositorio(documentoContext);

        public UnidadTrabajo(DocumentoContext documentoContext)
        {
            this.documentoContext = documentoContext;
        }

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
