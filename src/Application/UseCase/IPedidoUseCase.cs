using Application.DTOs;
using Domain.Entities;

namespace Application.UseCase
{
    public interface IPedidoUseCase
    {
        Task<PedidoDto> Inserir(CadastrarPedidoDto pedidoDto);
        Task<IEnumerable<PedidoDto>> Listar();
    }
}
