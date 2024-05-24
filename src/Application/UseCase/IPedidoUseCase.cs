using Application.DTOs;
using Domain.Entities;

namespace Application.UseCase
{
    public interface IPedidoUseCase
    {
        Task<PedidoDto> Inserir(PedidoDto pedidoDto);
        Task<IEnumerable<PedidoDto>> Listar();
    }
}
