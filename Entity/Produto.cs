using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace livrariaApi.Entity
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Descricao")]

        public string Descricao { get; set; }
        [Column("Preco")]
        public float Preco { get; set; }
        [Column("Qtd")]
        public int Quantidade{get;set;}
        [Column("cor")]
        public string Cor{get;set;}
    }
}