using Entidades.Entidades;
using InfraEstructura.Contratos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstructuraRepositorios
{
    public class AreaRepositorio : BaseRepositorio<Area>, IArea
    {
        public AreaRepositorio(DbContext context) : base(context)
        {

        }
    }
}
