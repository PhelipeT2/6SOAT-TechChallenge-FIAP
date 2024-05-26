using Domain.Entities;

namespace Domain.Ports
{
    public interface IClienteRepository
    {
        Task<Cliente> ObterPorCPF(string cpf);
        Task<Cliente> Inserir(Cliente cliente);
        bool ValidaCliente(string cpf);
    }
}
