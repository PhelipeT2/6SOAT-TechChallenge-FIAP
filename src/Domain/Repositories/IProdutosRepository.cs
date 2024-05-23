using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IProdutosRepository
    {
        Task<Produto> ObterProdutoPorId(long id);
        Task<List<Produto>> ListarProdutos();
        Task<Produto> InserirProdutos(Produto produto);
        Task<Produto> AtualizarProdutos(Produto produto);
        Task ExcluirProdutos(long id);
        Task<List<Produto>> ListarPorCategoria(long idCategoria);
    }
}
