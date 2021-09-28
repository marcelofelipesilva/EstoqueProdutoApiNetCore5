using System.ComponentModel.DataAnnotations;

namespace EstoqueProdutoApi.Models.ContaAcesso
{
    public class ContaAcessoViewModelInput
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Matricula é obrigatório")]
        public int Matricula { get; set; }
        [Required(ErrorMessage = "O campo Login  é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        public string Senha { get; set; }

    }
}