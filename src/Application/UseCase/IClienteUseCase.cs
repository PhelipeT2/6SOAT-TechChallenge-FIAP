using Domain.Entities;

namespace Application.UseCase
{
    public interface IClienteUseCase
    {
        Task<Cliente> Obter(string cpf);
        Task<Cliente> Cadastrar(Cliente cliente);
    }
}
