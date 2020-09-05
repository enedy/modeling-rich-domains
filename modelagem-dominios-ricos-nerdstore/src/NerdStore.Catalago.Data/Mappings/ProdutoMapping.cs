using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalago.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalago.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(250)");

            builder.Property(x => x.Descricao).IsRequired().HasColumnType("varchar(500)");

            builder.Property(x => x.Imagem).IsRequired().HasColumnType("varchar(250)");

            builder.OwnsOne(navigationExpression: x => x.Dimensoes, buildAction: cm =>
            {
                cm.Property(c => c.Altura).HasColumnName("Altura").HasColumnType("int");
                cm.Property(c => c.Largura).HasColumnName("Largura").HasColumnType("int");
                cm.Property(c => c.Profundidade).HasColumnName("Profundidade").HasColumnType("int");
            });

            builder.ToTable("Produtos");
        }
    }
}
