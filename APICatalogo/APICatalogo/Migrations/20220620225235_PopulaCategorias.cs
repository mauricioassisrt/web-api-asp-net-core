using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categoria (Nome, ImagemUrl) Values ('Bebidas', 'bebida.jpg')");
            mb.Sql("Insert into Categoria (Nome, ImagemUrl) Values ('Bebidas 2', 'bebida.jpg')");
            mb.Sql("Insert into Categoria (Nome, ImagemUrl) Values ('Bebidas 3', 'bebida.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categoria");
        }
    }
}
