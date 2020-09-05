using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NerdStore.Catalogo.Application.DTO
{
    public class CategoriaDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O Campoo {0} é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campoo {0} é obrigatório")]
        public int Codigo { get; set; }
    }
}
