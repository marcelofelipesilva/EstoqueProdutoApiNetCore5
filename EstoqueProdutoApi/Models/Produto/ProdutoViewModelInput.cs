using System.ComponentModel.DataAnnotations;

namespace EstoqueProdutoApi.Models.Produto
{
    public class ProdutoViewModelInput
    {
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public double Preco { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Descricao { get; set; }
    }
}