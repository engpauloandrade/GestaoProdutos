using GestaoProdutos.Domain.Model;
using System.Collections.Generic;

namespace GestaoProdutos.Domain.Interfaces
{
    public interface IProdutoService<T>
        where T : class
    {
        Task<IEnumerable<T>> GetFiltrado(string filtro, int page, int pageSize);
        Task<IEnumerable<T>> GetPorCodigo(string codigo);


    }
}
