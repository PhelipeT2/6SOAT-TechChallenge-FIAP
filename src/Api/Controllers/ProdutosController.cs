using Application.UseCase.Produtos;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosUseCase _produtosUseCase;

        public ProdutosController(IProdutosUseCase produtosUseCase)
        {
            _produtosUseCase = produtosUseCase;
        }

        // GET: api/<ProdutosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _produtosUseCase.Listar();

            return Ok(produtos);
        }

        //// GET api/<ProdutosController>/5
        //[HttpGet("{id}")]
        //public string GetById(int id)
        //{
        //    //var produtos = await _produtosUseCase.ObterProdutos(id);

        //    return Ok(produtos);
        //}

        // GET api/<ProdutosController>/5
        [HttpGet("categoria-produtos/{id}")]
        public string GetCategoriaProdutos(int id)
        {
            return "value";
        }

        // POST api/<ProdutosController>
        //[HttpPost]
        //public async Task<IActionResult> Cadastrar(Produto produto)
        //{
        //    await _produtosUseCase.InserirProdutos(produto);

        //    return Ok();
        //}

        // PUT api/<ProdutosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}