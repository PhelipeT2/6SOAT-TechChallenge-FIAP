using Domain.Entities;

namespace Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> ObterPorCPF(string cpf);
        Task<Cliente> ObterPorId(long id);
        Task<Cliente> Inserir(Cliente cliente); 
        bool ValidaCliente(string cpf);
    }
}
