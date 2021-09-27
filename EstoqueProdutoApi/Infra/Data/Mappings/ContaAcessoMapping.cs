using EstoqueProdutoApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueProdutoApi.Infra.Data.Mappings
{
    public class ContaAcessoMapping: IEntityTypeConfiguration<ContaAcesso>
    {
        public void Configure(EntityTypeBuilder<ContaAcesso> builder)
        {
            builder.ToTable("TB_ContatoAcesso");
            builder.HasKey(p => p.ContaAcessoID);
            builder.Property(p => p.ContaAcessoID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Matricula);
            builder.Property(p => p.Login);
            builder.Property(p => p.Senha);
           
        }
    }
}