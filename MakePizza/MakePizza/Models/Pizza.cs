using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        #region Propriedades
  
        [Key]
        public int IdPizza { get; set; }

        public List<Ingrediente_Pizza> lstIngredientes { get; set; }

        [Display(Name = "Tamanho Pizza")]
        [Required(ErrorMessage = "Tamanho Obrigatório ")]
        public int TamanhoPizza { get; set; }

        [Display(Name = "Preço Pizza")]
        [Required(ErrorMessage = "Preço Obrigatório ")]
        public double PrecoPizza { get; set; }

        [Display(Name = "Status Pizza")]
        [Required(ErrorMessage = "Status Obrigatório ")]
        public string StatusPizza { get; set; }

        #endregion
    }
}