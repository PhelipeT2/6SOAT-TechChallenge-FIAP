using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPedidoRepository
    {
        Task<Pedido> Inserir(Pedido pedido);
    }
}
