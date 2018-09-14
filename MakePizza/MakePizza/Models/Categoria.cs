using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Display(Name = "Nome Categoria")]
        [Required(ErrorMessage = "Nome Obrigatório ")]
        public string NomeCategoria { get; set; }

        [Display(Name = "Descrição Categoria")]
        [Required(ErrorMessage = "Descrição Obrigatório ")]
        public string DescricaoCategoria { get; set; }

        [Display(Name = "Status Categoria")]
        public bool StatusCategoria { get; set; }
    }
}