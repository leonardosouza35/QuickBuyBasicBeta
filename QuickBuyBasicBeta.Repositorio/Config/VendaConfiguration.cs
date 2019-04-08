using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyBasicBeta.Dominio.Entidades;

namespace QuickBuyBasicBeta.Repositorio.Config
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.DataVenda)
                .IsRequired();
            builder
                .Property(p => p.UsuarioId);            
        }
    }
}
