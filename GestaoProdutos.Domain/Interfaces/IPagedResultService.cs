using GestaoProdutos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Interfaces
{
    public interface IPagedResultService<T>
    {
        public PagedResult<T> GetPagedResult(IQueryable<T> query, int page, int pageSize);
    }
}
