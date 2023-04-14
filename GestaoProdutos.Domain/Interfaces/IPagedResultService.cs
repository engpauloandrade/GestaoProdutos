using GestaoProdutos.Domain.Model;

namespace GestaoProdutos.Domain.Interfaces
{
    public interface IPagedResultService<T>
    {
        public PagedResult<T> GetPagedResult(IQueryable<T> query, int page, int pageSize);
    }
}
