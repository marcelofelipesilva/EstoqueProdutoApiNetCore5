namespace EstoqueProdutoApi.Models.Produto
{
    public class ProdutoViewModelOutput
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
    }
}