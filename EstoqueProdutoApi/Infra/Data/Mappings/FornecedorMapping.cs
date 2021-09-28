using EstoqueProdutoApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueProdutoApi.Infra.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("TB_Fornecedor");
            builder.HasKey(p => p.FornecedorID);
            builder.Property(p => p.FornecedorID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            
        }
    }
}