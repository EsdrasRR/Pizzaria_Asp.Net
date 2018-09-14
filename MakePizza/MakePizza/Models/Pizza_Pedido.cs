using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    [Table("Pizza_Pedido")]
    public class Pizza_Pedido
    {
        #region Propriedades

        [Key]
        public int IdPizza_Pedido { get; set; }

        public Pizza pizza { get; set; }

        #endregion
    }
}