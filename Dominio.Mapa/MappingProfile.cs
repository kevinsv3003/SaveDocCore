using Dominio.EntidadesDto;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Dominio.Mapa
{
    public class MappingProfile :Profile
    {

        public MappingProfile()
        {
            CreateMap<Area, AreaDto>().ReverseMap();
            CreateMap<AreaDto, Area>().ReverseMap();
            
            CreateMap<Documento, DocumentoDto>().ReverseMap();
            CreateMap<DocumentoDto, Documento>().ReverseMap();

            CreateMap<UsuarioApp, UsuarioDto>().ReverseMap();
            CreateMap<UsuarioDto, UsuarioApp>().ReverseMap();

        }
    }
}
