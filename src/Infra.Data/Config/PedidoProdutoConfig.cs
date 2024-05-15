using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Config
{
    public class PedidoProdutoConfig : IEntityTypeConfiguration<PedidoProduto>
    {
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)
        {
            builder.HasKey(x => new { x.ProdutoId, x.PedidoId });

            builder.Property(x => x.Quantidade).IsRequired();

            builder.HasOne(x => x.Produto);

            builder.HasOne(x => x.Pedido);
        }
    }
}
