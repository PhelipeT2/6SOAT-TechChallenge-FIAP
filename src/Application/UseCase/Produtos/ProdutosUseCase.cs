using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCase.Produtos
{
    public class ProdutosUseCase : IProdutosUseCase
    {
        private readonly IProdutosRepository _produtosRepository;

        public ProdutosUseCase(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }

        public async Task<Produto> Obter(long id)
        {
            return await _produtosRepository.ObterProdutoPorId(id);
        }

        public async Task<List<Produto>> Listar()
        {
            return await _produtosRepository.ListarProdutos();
        }

        public async Task<Produto> Cadastrar(Produto produto)
        {
            return await _produtosRepository.InserirProdutos(produto);
        }

        public async Task<Produto> Atualizar(Produto produto)
        {
             return await _produtosRepository.AtualizarProdutos(produto);
        }

        public async Task Excluir(long id)
        {
            await _produtosRepository.ExcluirProdutos(id);
        }
    }
}
