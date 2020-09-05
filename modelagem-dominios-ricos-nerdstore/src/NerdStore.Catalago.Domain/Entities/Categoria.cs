using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalago.Domain.Entities
{
    public class Categoria : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public ICollection<Produto> Produtos { get; set; }

        protected Categoria() { }

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            AssertionConcern.ValidarSeVazio(valor: Nome, message: "O campo Nome do produto não pode estar vazio");
        }
    }
}
