namespace GestaoProdutos.Domain.Interfaces
{
    public interface IProdutoService<DTO> where DTO : class
    {
        Task<IEnumerable<DTO>> Get(int page, int pageSize);
    }
}
