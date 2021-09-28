using System.Linq;
using EstoqueProdutoApi.Infra.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EstoqueProdutoApi.Configurations
{
    public static class EntityFrameworkExtensions {
      
        public static IApplicationBuilder UseApplyMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var EstoqueProdutoApiDbcontext = serviceScope.ServiceProvider.GetService<EstoqueProdutoApiDbcontext>())
                {
                    var migracoesPendentes = EstoqueProdutoApiDbcontext.Database.GetPendingMigrations();

                    if (migracoesPendentes.Count() == 0)
                    {
                        return app;
                    }

                    EstoqueProdutoApiDbcontext.Database.Migrate();
                }
            }

            return app;
        }
    }
}