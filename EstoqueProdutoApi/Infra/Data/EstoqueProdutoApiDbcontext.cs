using EstoqueProdutoApi.Business.Entities;
using EstoqueProdutoApi.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EstoqueProdutoApi.Infra.Data
{
    public class EstoqueProdutoApiDbcontext : DbContext
    {
        public EstoqueProdutoApiDbcontext(DbContextOptions<EstoqueProdutoApiDbcontext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaAcessoMapping());
            modelBuilder.ApplyConfiguration(new FornecedorMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
           
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=172.17.0.6;Database=EstoqueProdutosApiBD;User Id=sa;Password=App@12345;");
        }

        public DbSet<ContaAcesso> Livros { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}