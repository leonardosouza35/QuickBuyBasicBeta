using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuyBasicBeta.Dominio.Entidades;
using QuickBuyBasicBeta.Repositorio.Config;

namespace QuickBuyBasicBeta.Repositorio.Contexto
{
    public class QuickBBContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }


        public QuickBBContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new VendaConfiguration());
            modelBuilder.ApplyConfiguration(new ItemVendaConfiguration());

            modelBuilder.Entity<Usuario>().HasData(new Usuario()
            {
                Id = 1,
                Email= "leo@haacademy.co",
                Senha = "abc23",
                Nome = "Leonardo",
                SobreNome = "Souza",                
            });

            modelBuilder.Entity<Produto>().HasData(new Produto()
            {
                Id =1,
                Nome = "Celular Samsung",
                Descricao = "Smartphone Samsung Galaxy J8 64GB Dual Chip Android 8.0 Tela 6 Octa - Core 1.8GHz 4G Câmera 16MP F1.7 + 5MP F1.9(Dual Cam) - Prata",
                Valor = 1249.00m
            });

            modelBuilder.Entity<Venda>().HasData(new Venda()
            {
                Id =1,
                UsuarioId =1,                
            });

            modelBuilder.Entity<ItemVenda>().HasData(new ItemVenda()
            {
                Id =1,
                ProdutoId = 1,   
                VendaId = 1
            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
