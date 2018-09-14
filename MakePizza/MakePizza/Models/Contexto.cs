using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MakePizza.Models
{
    public class Contexto : DbContext
    {
        public Contexto(): base("DbMakePizza") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingrediente> Ingedientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}