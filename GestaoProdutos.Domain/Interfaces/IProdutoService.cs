using GestaoProdutos.Domain.Model;

namespace GestaoProdutos.Domain.Interfaces
{
    public interface IProdutoService<T>
        where T : class
    {
        Task<IEnumerable<T>> GetFiltrado(string filtro, int page, int pageSize);
        Task<IEnumerable<T>> GetPorCodigo(string codigo);
        Task<T> PostProduto(Produto produto);
        Task<T> AtualizaProduto(string codigo, Produto produto);
        Task<T> DeletaProduto(string codigo);



    }
}
