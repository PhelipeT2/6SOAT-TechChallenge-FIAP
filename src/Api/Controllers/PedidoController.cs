using Application.DTOs;
using Application.UseCase;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoUseCase _pedidoUseCase;
        public PedidoController(IPedidoUseCase pedidoUseCase)
        {
            _pedidoUseCase = pedidoUseCase;
        }        

        [HttpPost]
        [Route("checkout")]
        public async Task<IActionResult> Inserir(CadastrarPedidoDto pedidoDto)
        {
            try
            {
                return Ok(await _pedidoUseCase.Inserir(pedidoDto));
            }
            catch(Exception ex)
            {
                return BadRequest(new { Mensagem = ex.Message });
            }
        }

        [HttpPut]
        [Route("fake-checkout/{id}")]
        public async Task<IActionResult> EnviarParaPagamento(long id)
        {
            try
            {
                return Ok(await _pedidoUseCase.EnviarPagamento(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Mensagem = ex.Message });
            }
        }

        [HttpPut]
        [Route("atualizar-status/{id}/{status}")]
        public async Task<IActionResult> AtualizarStatus(long id, int status)
        {
            try
            {
                return Ok(await _pedidoUseCase.AtualizarStatus(id, (StatusEnum)status));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Mensagem = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {          
            return Ok(await _pedidoUseCase.Listar());
        }
    }
}
