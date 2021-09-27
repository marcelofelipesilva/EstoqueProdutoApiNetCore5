using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueProdutoApi.Business.Entities
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        [StringLength(350)]
        public string Descricao { get; set; }

       // public Fornecedor Fornecedor { get; set; }
    }
}