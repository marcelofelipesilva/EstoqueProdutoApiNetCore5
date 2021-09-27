using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueProdutoApi.Business.Entities
{
    public class ContaAcesso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContaAcessoID { get; set; }
        [StringLength(30)]
        public string Nome { get; set; }
        public int Matricula { get; set; }
        [StringLength(15)]
        public string Login { get; set; }
        [StringLength(8)]
        public string Senha { get; set; }
        
    }
}