using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCase
{
    public class PedidoUseCase : IPedidoUseCase
    {
        private readonly IPedidoRepository _repository;
        public PedidoUseCase(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Pedido> Inserir(Pedido pedido)
        {
            return await _repository.Inserir(pedido);
        }
    }
}
