using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly TechChallengeContext _context;

        public ProdutosRepository(TechChallengeContext context)
        {
            _context = context;
        }

        public async Task<Produto> ObterProdutoPorId(long id) => await _context.Produto.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<Produto>> ListarProdutos()
        {
            return _context.Produto.Include(x => x.Categoria).ToList();
             
        }

        public async Task<Produto> InserirProdutos(Produto produto)
        {
            if (produto is null)
            {
                throw new ArgumentNullException(nameof(produto));
            }
            var categoria = await _context.Categoria.FirstOrDefaultAsync(x => x.Id == produto.Categoria.Id);
            produto.Categoria = categoria;
            _context.Produto.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> AtualizarProdutos(Produto produto)
        {
            var produtoDb = _context.Produto.Find(produto.Id);
            produtoDb.Valor = 

                
            _context.Produto.Update(produtoDb);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task ExcluirProdutos(long id)
        {
             _context.Produto.Remove(_context.Produto.Find(id));
            await _context.SaveChangesAsync();
           
        }

        public async Task<List<Produto>> ListarPorCategoria(long idCategoria)
        {
            var produtosCategoria =  _context.Produto.Include(x => x.Categoria).Where(x => x.Categoria.Id == idCategoria);
            return produtosCategoria.ToList();
        }
    }
}
