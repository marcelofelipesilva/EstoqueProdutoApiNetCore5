using System.Collections.Generic;
using System.Linq;
using EstoqueProdutoApi.Business.Entities;
using EstoqueProdutoApi.Business.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EstoqueProdutoApi.Infra.Data.Mappings
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly EstoqueProdutoApiDbcontext _dbcontext;

        public ProdutoRepository(EstoqueProdutoApiDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void AdicionarProduto(Produto produto)
        {
            _dbcontext.Add(produto);
        }

        public void Commit()
        {
            _dbcontext.SaveChanges();
        }

        public List<Produto> obterProdutos(int ProdutoID)
        {
            return _dbcontext.Produtos.Include(i => i.ProdutoID).Where(w => w.ProdutoID == ProdutoID).ToList();

        }
    }
}