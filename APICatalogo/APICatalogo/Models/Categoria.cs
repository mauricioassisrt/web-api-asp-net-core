using System.Collections.ObjectModel;

namespace APICatalogo.Models
{
    public class Categoria
    {
        //inicializa a coleção na qual faz relacionamento entre produtos e categorias 
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }
        //IColection define uma propriedade de navegação 
        public ICollection<Produto>? Produtos { get; set; }
    }
}
