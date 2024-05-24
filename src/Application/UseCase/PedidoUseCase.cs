using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCase
{
    public class PedidoUseCase : IPedidoUseCase
    {
        private readonly IPedidoRepository _repository;
        private readonly IProdutosRepository _produtoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public PedidoUseCase(IPedidoRepository repository, IProdutosRepository produtoRepository, IClienteRepository clienteRepository, IMapper mapper)
        {
            _repository = repository;
            _produtoRepository = produtoRepository;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<PedidoDto> Inserir(CadastrarPedidoDto pedidoDto)
        {
            Cliente cliente = null;

            if(pedidoDto.ClienteId.HasValue && pedidoDto.ClienteId.Value > 0)
            {
                cliente = await _clienteRepository.ObterPorId(pedidoDto.ClienteId.Value);
                
                if(cliente == null) throw new Exception("Cliente inválido");
            }
                

            var pedidoProdutos = pedidoDto.Produtos.Select(x =>
            {
                var produto = _produtoRepository.ObterProdutoPorId(x.ProdutoId).GetAwaiter().GetResult();

                if (produto == null) throw new Exception($"ProdutoId {x.ProdutoId} inválido");

                return new PedidoProduto(x.ProdutoId, x.Quantidade, x.Observacao, produto);
            })
            .ToList();

            var pedido = new Pedido(cliente, pedidoProdutos);

            return _mapper.Map<PedidoDto>(await _repository.Inserir(pedido));
        }

        public async Task<IEnumerable<PedidoDto>> Listar()
        {
            return _mapper.Map<IEnumerable<PedidoDto>>(await _repository.ListarPedidos());
        }
    }
}
