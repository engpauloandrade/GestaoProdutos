﻿using GestaoProdutos.Application.DTO;
using GestaoProdutos.Application.Filters;
using GestaoProdutos.Application.Pagination;
using GestaoProdutos.Application.Services;
using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using GestaoProdutos.Persistence.Database;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProdutos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApiDbContext _ctx;
        private readonly IProdutoService<ProdutoDTO> _produtoService;

        public ProductController(ApiDbContext ctx, IProdutoService<ProdutoDTO> produtoService)
        {
            this._produtoService = produtoService;
            this._ctx = ctx;
        }

        // Listar todos os produtos 
        [HttpGet]
        public IActionResult GetProdutosList([FromQuery] string filtro, [FromQuery] int pagina = PaginacaoBase.PAGINA_PADRAO, [FromQuery] int tamanhoPagina = PaginacaoBase.TAMANHO_PADRAO)
        {
            try
            {
                var produtoPaginado = _produtoService.GetFiltrado(filtro, pagina, tamanhoPagina);
                return Ok(produtoPaginado.Result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }




        // Recuperar um produto pelo código
        [HttpGet("{codigo}")]
        public IActionResult Get(string codigo)
        {
            try
            {
                var produto = _ctx.Produtos?.FirstOrDefault(p => p.Codigo.Equals(codigo));
                return Ok(new List<Produto> { produto });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // Inserir produto
        [HttpPost]
        public IActionResult Post(ProdutoDTO produto)
        {
            return Ok();
        }

        // Editar produto
        [HttpPut("{codigo}")]
        public IActionResult Put(int codigo, Produto produto)
        {

            return Ok();

        }

        // Excluir produto
        [HttpDelete("{codigo}")]
        public IActionResult Delete(int codigo)
        {
            return Ok();
        }
    }
}
