using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using GestaoProdutos.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Application.Services
{
    public class PagedResultService<T> : IPagedResultService<T>
    {
        private readonly ApiDbContext _context;

        public PagedResultService(ApiDbContext context)
        {
            _context = context;
        }

        public PagedResult<T> GetPagedResult(IQueryable<T> query, int page, int pageSize)
        {
            var skipCount = (page - 1) * pageSize;

            var items = query.Skip(skipCount).Take(pageSize).ToList();

            var totalCount = query.Count();

            var hasNext = (skipCount + items.Count) < totalCount;

            return new PagedResult<T>(items, totalCount, hasNext);
        }
    }
}
