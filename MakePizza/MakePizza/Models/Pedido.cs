using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Display(Name = "Pizza Pedido")]
        public List<Pizza_Pedido> PizzasPedido { get; set; }

        [Display(Name = "Cliente Pedido")]
        public Cliente ClientePedido { get; set; }

        [Display(Name = "Data Pedido")]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Status Pedido")]
        [Required(ErrorMessage = "Status Obrigatório ")]
        public string StatusPedido { get; set; }

        [Display(Name = "Preço Total do Pedido")]
        [Required(ErrorMessage = "Preço Total Obrigatório ")]
        public double PrecoTotalPedido { get; set; }

    }
}