using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPedidoRepository
    {
        Task<List<Pedido>> ListarPedidos();
        Task<Pedido> ObterPorId(long id);
        Task<Pedido> Inserir(Pedido pedido);
        Task<Pedido> Atualizar(Pedido pedido);
    }
}
