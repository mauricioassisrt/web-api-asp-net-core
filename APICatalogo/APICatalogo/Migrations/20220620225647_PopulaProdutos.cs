using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO produto (Nome,Descricao,Preco,ImageUrl,Estoque,DataCadastro,CategoriaId)"+
                "Values ('Coca', 'Refrig', 5.45, 'cocacola.jpg', 50, now(), 1)");

            mb.Sql("INSERT INTO produto (Nome,Descricao,Preco,ImageUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values ('Coca2', '2Refrig', 5.45, '2cocacola.jpg', 50, now(), 2)");

            mb.Sql("INSERT INTO produto (Nome,Descricao,Preco,ImageUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values ('Coca3', '3Refrig', 5.45, '3cocacola.jpg', 50, now(), 3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produto");
        }
    }
}
