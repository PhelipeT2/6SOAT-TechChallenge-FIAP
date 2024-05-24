using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Domain.Repositories;
using System;

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

        public async Task<PedidoDto> EnviarPagamento(long id)
        {
            var pedido = await _repository.ObterPorId(id);

            if(pedido is null) throw new Exception($"PedidoId {id} inválido");

            pedido.AtualizarStatus(StatusEnum.Recebido);

            return _mapper.Map<PedidoDto>(await _repository.Atualizar(pedido));
        }

        public async Task<PedidoDto> AtualizarStatus(long id, StatusEnum status)
        {
            var pedido = await _repository.ObterPorId(id);

            if (pedido is null) throw new Exception($"PedidoId {id} inválido");

            if (pedido.Status > status) throw new Exception($"Status não pode retroceder");

            if (!Enum.IsDefined(typeof(StatusEnum), status)) throw new Exception($"Status {status} inválido");

            pedido.AtualizarStatus(status);

            return _mapper.Map<PedidoDto>(await _repository.Atualizar(pedido));
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

            var pedido = new Pedido(cliente, pedidoProdutos, pedidoDto.Viagem);

            return _mapper.Map<PedidoDto>(await _repository.Inserir(pedido));
        }

        public async Task<IEnumerable<PedidoDto>> Listar()
        {
            return _mapper.Map<IEnumerable<PedidoDto>>(await _repository.ListarPedidos());
        }
    }
}
