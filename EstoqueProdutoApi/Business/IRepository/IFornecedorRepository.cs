using System.Collections.Generic;
using EstoqueProdutoApi.Business.Entities;

namespace EstoqueProdutoApi.Business.IRepository
{
    public interface IFornecedorRepository
    {
        void AdicionarConatAcesso(Fornecedor fornecedor);
        void Commit();

        List<Fornecedor> obterFornecedores(int FornecedorID);
    }
}