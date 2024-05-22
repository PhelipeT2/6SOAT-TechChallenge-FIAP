using Domain.Entities;

namespace Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> ObterPorCPF(string cpf);
        Task<Cliente> Inserir(Cliente cliente);       
    }
}
