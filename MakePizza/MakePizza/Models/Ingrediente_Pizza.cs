using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    [Table("Ingrediente_Pizza")]
    public class Ingrediente_Pizza
    {
        #region Propriedades

        [Key]
        public int IdIngrediente_Pizza { get; set; }

        public Ingrediente ingrediente { get; set; }

        #endregion
    }
}