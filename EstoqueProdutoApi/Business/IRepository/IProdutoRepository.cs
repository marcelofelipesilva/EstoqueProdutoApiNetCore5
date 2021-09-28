using System.Collections.Generic;
using EstoqueProdutoApi.Business.Entities;

namespace EstoqueProdutoApi.Business.IRepository
{
    public interface IProdutoRepository
    {
        void AdicionarProduto(Produto produto);
        void Commit();

        List<Produto> obterProdutos(int ProdutoID);
    }
}