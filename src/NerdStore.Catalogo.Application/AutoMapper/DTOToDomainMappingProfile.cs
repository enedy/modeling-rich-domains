using AutoMapper;
using NerdStore.Catalago.Domain.Entities;
using NerdStore.Catalago.Domain.ValuableObject;
using NerdStore.Catalogo.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    public class DTOToDomainMappingProfile : Profile
    {
        public DTOToDomainMappingProfile()
        {
            CreateMap<ProdutoDTO, Produto>()
                .ConstructUsing(ctor: p => new Produto(p.Nome, p.Descricao, p.Ativo, p.Valor,
                p.CategoriaId, p.DataCadastro, p.Imagem, new Dimensoes(p.Altura, p.Largura, p.Profundidade)));

            CreateMap<CategoriaDTO, Categoria>()
               .ConstructUsing(ctor: c => new Categoria(c.Nome, c.Codigo));
        }
    }
}
