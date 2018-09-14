using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public Pizza PedidoPizza { get; set; }
        public Cliente PedidoCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public double PrecoTotalPedido { get; set; }

    }
}