using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public bool StatusCategoria { get; set; }
    }
}