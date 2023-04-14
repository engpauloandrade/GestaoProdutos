using AutoMapper;
using GestaoProdutos.Application.DTO;
using GestaoProdutos.Application.Filters;
using GestaoProdutos.Application.Pagination;
using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProdutos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProdutoService<ProdutoDTO> _produtoService;
        private readonly IMapper _mapper;

        public ProductController(IProdutoService<ProdutoDTO> produtoService, IMapper mapper)
        {
            this._mapper= mapper;
            this._produtoService = produtoService;
 
        }

        // Listar todos os produtos 
        [HttpGet]
        public IActionResult GetProdutosList([FromQuery] FiltroProdutos? filtro, [FromQuery] int pagina = PaginacaoBase.PAGINA_PADRAO, [FromQuery] int tamanhoPagina = PaginacaoBase.TAMANHO_PADRAO)
        {
            try
            {
                var produtoPaginado = _produtoService.GetFiltrado(filtro.Descricao, pagina, tamanhoPagina);
                return Ok(produtoPaginado.Result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Recuperar um produto pelo código
        [HttpGet("{codigo}")]
        public IActionResult GetProduto(string codigo)
        {
            try
            {
                var produtoCodigo = _produtoService.GetPorCodigo(codigo);
                return Ok(produtoCodigo.Result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Inserir produto
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdutoDTO produtoDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = _mapper.Map<Produto>(produtoDTO);
                    var produtoCriado = await _produtoService.PostProduto(produto);
                    return Ok(produtoCriado);
                }
                catch (InvalidOperationException ex)
                {
                    return BadRequest("Produto já cadastrado.");
                }
                catch (ArgumentException ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            return BadRequest(ModelState);
        }


        // Editar produto
        [HttpPut("{codigo}")]
        public async Task<IActionResult> AtualizarProduto(string codigo, [FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoDTO);
                var produtoAtualizado = await _produtoService.AtualizaProduto(codigo, produto);

                return Ok(produtoAtualizado);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // Excluir produto
        [HttpDelete("{codigo}")]
        public async Task<IActionResult> Delete(string codigo)
        {
            try
            {
                var produtoDeletado = await _produtoService.DeletaProduto(codigo);
                return Ok("Produto excluído com sucesso.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
