using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.UseCase.Produtos
{
    public interface IProdutosUseCase
    {
        Task<Produto> Obter(long id);
        Task<List<Produto>> Listar();
        Task<Produto> Cadastrar(Produto produto);
        Task<Produto> Atualizar(Produto produto);
        Task Excluir(long id);
    }
}