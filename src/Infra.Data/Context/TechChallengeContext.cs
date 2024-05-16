using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infra.Data.Context
{
    public sealed class TechChallengeContext : DbContext
    {         
        public TechChallengeContext(DbContextOptions<TechChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }      
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoProduto> PedidoProduto { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categoria>()
               .HasData(
                    new Categoria { Id = 1, Descricao = "Lanche" },
                    new Categoria { Id = 2, Descricao = "Acompanhamento" },
                    new Categoria { Id = 3, Descricao = "Bebida" },
                    new Categoria { Id = 4, Descricao = "Sobremesa" }
               );

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());         
        }
    }
}
