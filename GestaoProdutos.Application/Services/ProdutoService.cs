using AutoMapper;
using GestaoProdutos.Application.DTO;
using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using GestaoProdutos.Persistence.Database;
using Microsoft.EntityFrameworkCore;

namespace GestaoProdutos.Application.Services
{
    public class ProdutoService : IProdutoService<ProdutoDTO>
    {
        private readonly IMapper _mapper;
        private readonly ApiDbContext _dbContext;
        private readonly IPagedResultService<Produto> _pagedResultService;
        public ProdutoService( IMapper mapper, ApiDbContext dbContext, IPagedResultService<Produto> _pagedResultService)
        {
            this._pagedResultService = _pagedResultService;
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public Task<IEnumerable<ProdutoDTO>> GetPorCodigo(string codigo)
        {
            var produto = _dbContext.Produtos?.FirstOrDefault(p => p.Codigo.Equals(codigo));
            var produtosDTO = _mapper.Map<ProdutoDTO>(produto);
            return Task.FromResult<IEnumerable<ProdutoDTO>>(new List<ProdutoDTO> { produtosDTO });
        }

        public async Task<IEnumerable<ProdutoDTO>> GetFiltrado(string filtro, int page, int pageSize)
        {
            IEnumerable<Produto> produtos;
            if (string.IsNullOrEmpty(filtro))
            {
                produtos = await _dbContext.Produtos.ToListAsync();
            }
            else
            {
                produtos = await _dbContext.Produtos.Where(p => p.Descricao.Contains(filtro)).ToListAsync();
            }

            var pagedProdutos = _pagedResultService.GetPagedResult(produtos.AsQueryable(), page, pageSize);
            var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(pagedProdutos.Items);
            return produtosDTO;
        }





    }
}
