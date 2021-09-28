using EstoqueProdutoApi.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EstoqueProdutoApi.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<EstoqueProdutoApiDbcontext>
    {
        public EstoqueProdutoApiDbcontext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EstoqueProdutoApiDbcontext>();
            EstoqueProdutoApiDbcontext contexto = new EstoqueProdutoApiDbcontext(optionsBuilder.Options);
            return contexto;
        }
    }
}