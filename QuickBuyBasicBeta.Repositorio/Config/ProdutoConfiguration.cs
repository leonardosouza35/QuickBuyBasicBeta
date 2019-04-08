using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyBasicBeta.Dominio.Entidades;

namespace QuickBuyBasicBeta.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(p => p.Valor)
                .IsRequired();                
        }
    }
}
