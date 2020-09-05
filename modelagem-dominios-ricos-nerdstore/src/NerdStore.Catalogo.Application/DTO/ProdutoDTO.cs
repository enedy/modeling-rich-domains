using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NerdStore.Catalogo.Application.DTO
{
    public class ProdutoDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public string Imagem { get; set; }

        [Range(1, int.MaxValue, ErrorMessage ="O campo {0} precisa ter o valor mínimo de {1}")]
        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public int QuantidadeEstoque { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor mínimo de {1}")]
        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public decimal Altura { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor mínimo de {1}")]
        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public decimal Largura { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor mínimo de {1}")]
        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public decimal Profundidade { get; set; }

        public IEnumerable<CategoriaDTO> Categorias { get; set; }
    }
}
