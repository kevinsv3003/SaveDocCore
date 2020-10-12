using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstructura.Contratos
{
    public interface IDocumento : IBaseRepositorio<Documento>
    {
        Task<Documento> ObtenerDocumentoByte(int documentoId);
        bool ActualizarDocByte(int docId, string extension, byte[] documento);
        bool InsertarDocumento(Documento doc);
    }
}
