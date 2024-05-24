﻿using Application.DTOs;
using Application.UseCase;
using Domain.Entities;
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
        public async Task<IActionResult> Inserir(CadastrarPedidoDto pedidoDto)
        {
            return Ok(await _pedidoUseCase.Inserir(pedidoDto));
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {          
            return Ok(await _pedidoUseCase.Listar());
        }
    }
}
