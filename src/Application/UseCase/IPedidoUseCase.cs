using Domain.Entities;

namespace Application.UseCase
{
    public interface IPedidoUseCase
    {
        Task<Pedido> Inserir(Pedido pedido);
    }
}
