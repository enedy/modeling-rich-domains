using NerdStore.Catalago.Domain.Entities;
using NerdStore.Catalago.Domain.ValuableObject;
using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            var ex = Assert.Throws<DomainException>(() => new Produto(nome: string.Empty, descricao: "Geladeira", ativo: true,
                valor: 1000, Guid.NewGuid(), dataCadastro: DateTime.Now, "imagem", new Dimensoes(altura: 10, largura: 10, profundidade: 10)));

            Assert.Equal(expected: "O campo Nome do produto não pode estar vazio", actual: ex.Message);
        }
    }
}
