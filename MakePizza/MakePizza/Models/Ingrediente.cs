using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public Categoria CategoriaIngrediente { get; set; }
        public string NomeIngrediente  { get; set; }
        public double PrecoIngrediente { get; set; }
        public bool StatusIngrediente { get; set; }

    }
}