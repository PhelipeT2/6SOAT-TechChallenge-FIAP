using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPedidoRepository
    {
        Task<List<Pedido>> ListarPedidos();
        Task<Pedido> Inserir(Pedido pedido);
    }
}
