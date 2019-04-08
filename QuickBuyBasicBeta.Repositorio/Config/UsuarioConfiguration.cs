﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyBasicBeta.Dominio.Entidades;

namespace QuickBuyBasicBeta.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);            
        }
    }
}
