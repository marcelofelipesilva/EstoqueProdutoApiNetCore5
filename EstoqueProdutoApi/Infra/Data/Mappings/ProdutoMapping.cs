using EstoqueProdutoApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueProdutoApi.Infra.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("TB_Produto");
            builder.HasKey(p => p.ProdutoID);
            builder.Property(p => p.ProdutoID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Preco);
            builder.Property(p => p.Quantidade);
            builder.Property(p => p.Descricao);
           
        }
    }
}