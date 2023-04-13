using AutoMapper;
using GestaoProdutos.Application.DTO;
using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using GestaoProdutos.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public async Task<IEnumerable<ProdutoDTO>> GetPaginado(string filtro, int page, int pageSize)
        {
            var produtos = _dbContext.Produtos.Where(p => p.Descricao.Contains(filtro ?? "")).ToList();
            var pagedProdutos = _pagedResultService.GetPagedResult(produtos.AsQueryable(), page, pageSize);
            var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(pagedProdutos.Items);
            return produtosDTO;
        }




    }
}
