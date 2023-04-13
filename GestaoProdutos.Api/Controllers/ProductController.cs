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
        private readonly IPagedResultService<Produto> _pagedResultService;

        public ProductController(ApiDbContext ctx, IPagedResultService<Produto> pagedResultService)
        {
            this._pagedResultService= pagedResultService;
            this._ctx = ctx;
        }

        // Listar todos os produtos 
        [HttpGet]
        public IActionResult GetProdutosList([FromQuery] FiltroProdutos? filtro, [FromQuery] int pagina = PaginacaoBase.PAGINA_PADRAO, [FromQuery] int tamanhoPagina = PaginacaoBase.TAMANHO_PADRAO)
        {
            try
            {
                var produtos = _ctx.Produtos.Where(p => p.Descricao.Contains(filtro.Descricao ?? ""));
                var pagedProdutos = _pagedResultService.GetPagedResult(produtos, pagina, tamanhoPagina);
                return Ok(pagedProdutos);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // Recuperar um produto por código
        [HttpGet("{codigo}")]
        public ActionResult<Produto> Get(int codigo)
        {
            return Ok();
        }


        // Inserir produto
        [HttpPost]
        public ActionResult<Produto> Post(Produto produto)
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
