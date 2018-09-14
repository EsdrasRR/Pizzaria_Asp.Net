using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    public class Pizza
    {
        public int IdPizza { get; set; }
        public List<Ingrediente> lstIngredientes { get; set; }
        public int TamanhoPizza { get; set; }
        public double PrecoPizza { get; set; }
        public string StatusPizza { get; set; }
    }
}