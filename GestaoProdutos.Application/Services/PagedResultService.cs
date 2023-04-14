using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using GestaoProdutos.Persistence.Database;

namespace GestaoProdutos.Application.Services
{
    public class PagedResultService<T> : IPagedResultService<T>
    {
        private readonly IApiDbContext _context;

        public PagedResultService(IApiDbContext context)
        {
            _context = context;
        }

        public PagedResult<T> GetPagedResult(IQueryable<T> query, int page, int pageSize)
        {
            // Calcula a quantidade de itens que devem ser ignorados para chegar na página solicitada
            var skipCount = (page - 1) * pageSize;

            // Seleciona uma quantidade de itens igual ao tamanho da página, ignorando os itens anteriores
            var items = query.Skip(skipCount).Take(pageSize).ToList();

            // Obtém a quantidade total de itens na consulta
            var totalCount = query.Count();

            // Verifica se há mais itens após a página solicitada
            var hasNext = (skipCount + items.Count) < totalCount;

            return new PagedResult<T>(items, totalCount, hasNext);
        }
    }
}
