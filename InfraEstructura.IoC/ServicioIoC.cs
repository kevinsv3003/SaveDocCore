using Dominio.Contratos;
using Dominio.ReglaNegocio;
using InfraEstructura.Contratos;
using InfraEstructura.UoW;
using InfraEstructuraRepositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstructura.IoC
{
    public class ServicioIoC
    {
        public static IServiceCollection Service(IServiceCollection services)
        {
            //REGISTRAMOS UNIDAD DE TRABAJO Y REPOSITORIOS
            services.AddScoped<IUnidadTrabajo, UnidadTrabajo>();
            services.AddScoped<IArea, AreaRepositorio>();
            services.AddScoped<IDocumento, DocumentoRepositorio>();


            //REGISTRAMOS LOS MODELOS DE NEGOCIO
            services.AddScoped<IDocumentoDominio, DocumentoNegocio>();
            services.AddScoped<IAreaDominio, AreaNegocio>();
            services.AddScoped<IUsuarioNegocio, UsuarioNegocio>();

            return services;
        }
    }
}
