using System.Collections.Generic;
using System.Linq;
using EstoqueProdutoApi.Business.Entities;
using EstoqueProdutoApi.Business.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EstoqueProdutoApi.Infra.Data.Mappings
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly EstoqueProdutoApiDbcontext _dbcontext;

        public FornecedorRepository(EstoqueProdutoApiDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        
        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            _dbcontext.Add(fornecedor);
        }

        public void Commit()
        {
            _dbcontext.SaveChanges();
        }

        public List<Fornecedor> obterFornecedores(int FornecedorID)
        {
            return _dbcontext.Fornecedores.Include(i => i.FornecedorID).Where(w => w.FornecedorID == FornecedorID).ToList();
        }
    }
}