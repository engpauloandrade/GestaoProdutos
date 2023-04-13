namespace GestaoProdutos.Domain.Interfaces
{
    public interface IFiltro<DTO> where DTO : class
    {
        public DTO? Dado();
    }
}
