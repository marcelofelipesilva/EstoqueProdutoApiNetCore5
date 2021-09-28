using System.Collections.Generic;
using System.Linq;
using EstoqueProdutoApi.Business.Entities;
using EstoqueProdutoApi.Business.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EstoqueProdutoApi.Infra.Data.Mappings
{
    public class ContaAcessoRepository : IContaAcessoRepository
    {
        private readonly EstoqueProdutoApiDbcontext _apiDbcontext;

        public ContaAcessoRepository(EstoqueProdutoApiDbcontext apiDbcontext)
        {
            _apiDbcontext = apiDbcontext;
        }

        public void AdicionarConatAcesso(ContaAcesso contaAcesso)
        {
            _apiDbcontext.Add(contaAcesso) ;
        }

        public void Commit()
        {
            _apiDbcontext.SaveChanges() ;
        }

        public List<ContaAcesso> obterContaAcessos(int ContaAcessoID)
        {
            return _apiDbcontext.ContaAcessos.Include(i => i.ContaAcessoID).Where(w => w.ContaAcessoID == ContaAcessoID).ToList();
        }
    }
}