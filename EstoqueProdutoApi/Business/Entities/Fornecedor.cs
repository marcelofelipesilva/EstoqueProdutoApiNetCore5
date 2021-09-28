using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueProdutoApi.Business.Entities
{
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FornecedorID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }   
        
    }
}