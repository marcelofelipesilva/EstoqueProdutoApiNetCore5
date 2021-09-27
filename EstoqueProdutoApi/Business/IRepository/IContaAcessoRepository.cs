using System.Collections.Generic;
using EstoqueProdutoApi.Business.Entities;

namespace EstoqueProdutoApi.Business.IRepository
{
    public interface IContaAcessoRepository
    {
        void AdicionarConatAcesso(ContaAcesso contaAcesso);
        void Commit();

        List<ContaAcesso> obterContaAcessos(int ContaAcessoID);

    }
}