using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;

namespace Infra.Data.Repositories
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly TechChallengeContext _context;

        public ProdutosRepository(TechChallengeContext context)
        {
            _context = context;
        }

        public Task<Produto> ObterProdutos(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ListarProdutos()
        {
            //_context.Produto.ToList();
            return Task.FromResult(_context.Produto.AsEnumerable());
        }

        public async Task<Produto> InserirProdutos(Produto produto)
        {
            //throw new NotImplementedException();
            _context.Produto.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public Task<Produto> AtualizarProdutos(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirProdutos(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> listarPorCategoria(Categoria idCategoria)
        {
            throw new NotImplementedException();
        }
    }
}
