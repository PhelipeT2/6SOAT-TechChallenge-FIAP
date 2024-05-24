using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCase
{
    public class PedidoUseCase : IPedidoUseCase
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public PedidoUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PedidoDto> Inserir(PedidoDto pedidoDto)
        {
            var pedidoProdutos = pedidoDto.Produtos.Select(x => new PedidoProduto(x.ProdutoId, x.Quantidade, x.Observacao)).ToList();
            var pedido = new Pedido(pedidoDto.ClienteId, pedidoProdutos);

            return _mapper.Map<PedidoDto>(await _repository.Inserir(pedido));
        }

        public async Task<IEnumerable<PedidoDto>> Listar()
        {
            return _mapper.Map<IEnumerable<PedidoDto>>(await _repository.ListarPedidos());
        }
    }
}
