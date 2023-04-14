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
            var produtos = _dbContext.Produtos.AsQueryable();

            if (!string.IsNullOrEmpty(filtro))
            {
                produtos = produtos.Where(p => p.Descricao.Contains(filtro));
            }

            var pagedProdutos = _pagedResultService.GetPagedResult(produtos, page, pageSize);

            var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(pagedProdutos.Items);

            return produtosDTO;
        }

        public async Task<ProdutoDTO> PostProduto(Produto produto)
        {
            var produtoExistente = await _dbContext.Produtos.FirstOrDefaultAsync(p => p.Codigo == produto.Codigo);

            if (produtoExistente != null)
            {
                throw new InvalidOperationException();
            }

            _dbContext.Produtos.Add(produto);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ProdutoDTO>(produto);
        }

        public async Task<ProdutoDTO> AtualizaProduto(string codigo, Produto produto)
        {
            var produtoExistente = await _dbContext.Produtos.FirstOrDefaultAsync(p => p.Codigo == codigo);

            if (produtoExistente == null)
            {
                throw new InvalidOperationException("Produto não encontrado.");
            }

            produtoExistente.Descricao = produto.Descricao;
            produtoExistente.Quantidade= produto.Quantidade;

            await _dbContext.SaveChangesAsync();

            var produtoAtualizadoDTO = _mapper.Map<ProdutoDTO>(produtoExistente);

            return produtoAtualizadoDTO;
        }


        public async Task<ProdutoDTO> DeletaProduto(string codigo)
        {
            var produto = await _dbContext.Produtos.FirstOrDefaultAsync(p => p.Codigo == codigo);

            if (produto == null)
            {
                throw new ArgumentException("Produto não encontrado.");
            }

            _dbContext.Produtos.Remove(produto);
            await _dbContext.SaveChangesAsync();

            var produtoDeletadoDTO = _mapper.Map<ProdutoDTO>(produto);

            return produtoDeletadoDTO;
        }

    }
}
