using Application.DTOs;
using Domain.Enums;

namespace Application.UseCase
{
    public interface IPedidoUseCase
    {
        Task<PedidoDto> Inserir(CadastrarPedidoDto pedidoDto);
        Task<PedidoDto> EnviarPagamento(long id);
        Task<PedidoDto> AtualizarStatus(long id, StatusEnum status);
        Task<IEnumerable<PedidoDto>> Listar();
    }
}
