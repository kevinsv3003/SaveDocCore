using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstructura.Contratos
{
    public interface IUnidadTrabajo
    {
        #region Declaraciones de propiedades y metodos de la interfase
        IArea AreaRepositorio { get; }
        IDocumento DocumentoRepositorio { get; }
        void commit();
        void RollBack();
        void Disposable();

        #endregion
    }
}
