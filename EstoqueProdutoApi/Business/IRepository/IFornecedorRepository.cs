using System.Collections.Generic;
using EstoqueProdutoApi.Business.Entities;

namespace EstoqueProdutoApi.Business.IRepository
{
    public interface IFornecedorRepository
    {
        void AdicionarFornecedor(Fornecedor fornecedor);
        void Commit();

        List<Fornecedor> obterFornecedores(int FornecedorID);
    }
}