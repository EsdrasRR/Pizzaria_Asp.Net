using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CepCliente { get; set; }
        public string CpfCliente { get; set; }
        public string EmailCliente { get; set; }
        public string SenhaCliente { get; set; }

    }
}