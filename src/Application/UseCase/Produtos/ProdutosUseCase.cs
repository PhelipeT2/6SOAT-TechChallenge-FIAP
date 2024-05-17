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

        public Task<Produto> Obter(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> Listar()
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> Cadastrar(Produto produto)
        {
            return await _produtosRepository.InserirProdutos(produto);
        }

        public Task<Produto> Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }
    }
}
