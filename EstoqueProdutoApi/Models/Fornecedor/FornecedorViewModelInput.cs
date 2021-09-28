using System.ComponentModel.DataAnnotations;

namespace EstoqueProdutoApi.Models.Fornecedor
{
    public class FornecedorViewModelInput
    {
        [Required(ErrorMessage = "O Campo Nome é obrigatório")]
        public string Nome { get; set; }   
        
    }    

}