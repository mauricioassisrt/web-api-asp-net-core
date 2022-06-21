using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(80)]
        public string? Descricao { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Preco { get; set; }
        [Required]
        [StringLength(80)]
        public string? ImageUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        //propriedade de navegação de produtos e categorias 
        public Categoria? Categoria { get; set; }
        public int? CategoriaId { get; set; }
    }
}
