using Domain.Entities;
using Domain.Ports;

namespace Application.UseCase
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly IClienteRepository _repository;
        public ClienteUseCase(IClienteRepository repository)
        {
            _repository = repository;
        }
        public async Task<Cliente> Cadastrar(Cliente cliente)
        {
            return await _repository.Inserir(cliente);
        }

        public async Task<Cliente> Obter(string cpf)
        {
            return await _repository.ObterPorCPF(cpf);
        }
    }
}
