using AutoMapper;
using NerdStore.Catalago.Domain.Entities;
using NerdStore.Catalogo.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>()
                .ForMember(destinationMember: d => d.Largura, memberOptions: o => o.MapFrom(mapExpression: s => s.Dimensoes.Largura))
                .ForMember(destinationMember: d => d.Altura, memberOptions: o => o.MapFrom(mapExpression: s => s.Dimensoes.Altura))
                .ForMember(destinationMember: d => d.Profundidade, memberOptions: o => o.MapFrom(mapExpression: s => s.Dimensoes.Profundidade));
            CreateMap<Categoria, CategoriaDTO>();
        }
    }
}
