using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace livrariaApi.Entity
{
    [Table("Produtos")]
        public class ProdutoCesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int ProdutoId { get; set; }
        [Column("NomeProduto")]
        public string NomeProduto { get; set; }
        [Column("MarcaProduto")]
        public string MarcaProduto { get; set; }
        [Column("Modelo")]
        public string Modelo { get; set; }

        [Column("PlacaMae")]
        public string PlacaMae { get; set; }
        [Column("MemoriaRam")]
        public int MemoriaRam { get; set; }
        [Column("HD")]
        public int HD { get; set; }

    }
}