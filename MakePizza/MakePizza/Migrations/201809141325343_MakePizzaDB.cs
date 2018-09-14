namespace MakePizza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakePizzaDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        NomeCategoria = c.String(nullable: false),
                        DescricaoCategoria = c.String(nullable: false),
                        StatusCategoria = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        NomeCliente = c.String(nullable: false),
                        CepCliente = c.String(maxLength: 8),
                        CpfCliente = c.String(maxLength: 11),
                        EmailCliente = c.String(nullable: false),
                        SenhaCliente = c.String(nullable: false),
                        AdminCliente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        IdPedido = c.Int(nullable: false, identity: true),
                        DataPedido = c.DateTime(nullable: false),
                        StatusPedido = c.String(nullable: false),
                        PrecoTotalPedido = c.Double(nullable: false),
                        ClientePedido_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdPedido)
                .ForeignKey("dbo.Cliente", t => t.ClientePedido_IdCliente)
                .Index(t => t.ClientePedido_IdCliente);
            
            CreateTable(
                "dbo.Pizza_Pedido",
                c => new
                    {
                        IdPizza_Pedido = c.Int(nullable: false, identity: true),
                        pizza_IdPizza = c.Int(),
                        Pedido_IdPedido = c.Int(),
                    })
                .PrimaryKey(t => t.IdPizza_Pedido)
                .ForeignKey("dbo.Pizza", t => t.pizza_IdPizza)
                .ForeignKey("dbo.Pedido", t => t.Pedido_IdPedido)
                .Index(t => t.pizza_IdPizza)
                .Index(t => t.Pedido_IdPedido);
            
            CreateTable(
                "dbo.Pizza",
                c => new
                    {
                        IdPizza = c.Int(nullable: false, identity: true),
                        TamanhoPizza = c.Int(nullable: false),
                        PrecoPizza = c.Double(nullable: false),
                        StatusPizza = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdPizza);
            
            CreateTable(
                "dbo.Ingrediente_Pizza",
                c => new
                    {
                        IdIngrediente_Pizza = c.Int(nullable: false, identity: true),
                        ingrediente_IdIngrediente = c.Int(),
                        Pizza_IdPizza = c.Int(),
                    })
                .PrimaryKey(t => t.IdIngrediente_Pizza)
                .ForeignKey("dbo.Ingrediente", t => t.ingrediente_IdIngrediente)
                .ForeignKey("dbo.Pizza", t => t.Pizza_IdPizza)
                .Index(t => t.ingrediente_IdIngrediente)
                .Index(t => t.Pizza_IdPizza);
            
            CreateTable(
                "dbo.Ingrediente",
                c => new
                    {
                        IdIngrediente = c.Int(nullable: false, identity: true),
                        NomeIngrediente = c.String(nullable: false),
                        PrecoIngrediente = c.Double(nullable: false),
                        StatusIngrediente = c.Boolean(nullable: false),
                        CategoriaIngrediente_IdCategoria = c.Int(),
                    })
                .PrimaryKey(t => t.IdIngrediente)
                .ForeignKey("dbo.Categoria", t => t.CategoriaIngrediente_IdCategoria)
                .Index(t => t.CategoriaIngrediente_IdCategoria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pizza_Pedido", "Pedido_IdPedido", "dbo.Pedido");
            DropForeignKey("dbo.Pizza_Pedido", "pizza_IdPizza", "dbo.Pizza");
            DropForeignKey("dbo.Ingrediente_Pizza", "Pizza_IdPizza", "dbo.Pizza");
            DropForeignKey("dbo.Ingrediente_Pizza", "ingrediente_IdIngrediente", "dbo.Ingrediente");
            DropForeignKey("dbo.Ingrediente", "CategoriaIngrediente_IdCategoria", "dbo.Categoria");
            DropForeignKey("dbo.Pedido", "ClientePedido_IdCliente", "dbo.Cliente");
            DropIndex("dbo.Ingrediente", new[] { "CategoriaIngrediente_IdCategoria" });
            DropIndex("dbo.Ingrediente_Pizza", new[] { "Pizza_IdPizza" });
            DropIndex("dbo.Ingrediente_Pizza", new[] { "ingrediente_IdIngrediente" });
            DropIndex("dbo.Pizza_Pedido", new[] { "Pedido_IdPedido" });
            DropIndex("dbo.Pizza_Pedido", new[] { "pizza_IdPizza" });
            DropIndex("dbo.Pedido", new[] { "ClientePedido_IdCliente" });
            DropTable("dbo.Ingrediente");
            DropTable("dbo.Ingrediente_Pizza");
            DropTable("dbo.Pizza");
            DropTable("dbo.Pizza_Pedido");
            DropTable("dbo.Pedido");
            DropTable("dbo.Cliente");
            DropTable("dbo.Categoria");
        }
    }
}
