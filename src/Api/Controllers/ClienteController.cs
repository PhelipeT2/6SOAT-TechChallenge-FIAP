using Application.UseCase;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteUseCase _clienteUseCase;
        public ClienteController(IClienteUseCase clienteUseCase)
        {
            _clienteUseCase = clienteUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Obter(string cpf)
        {
            var cliente = await _clienteUseCase.Obter(cpf);

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Cliente cliente)
        {
            await _clienteUseCase.Cadastrar(cliente);

            return Ok();
        }
    }
}
