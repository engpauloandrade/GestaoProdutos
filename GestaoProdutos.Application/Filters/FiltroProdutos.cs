using GestaoProdutos.Application.DTO;
using GestaoProdutos.Domain.Interfaces;

namespace GestaoProdutos.Application.Filters
{
    public class FiltroProdutos : IFiltro<ProdutoDTO>
    {

        public string? Codigo { get; set; } = string.Empty;

        public ProdutoDTO? Dado()
        {
            ProdutoDTO produto = new();

            if (!string.IsNullOrEmpty(this.Codigo))
            {
                produto.Codigo = this.Codigo;

            }
            return produto;
        }
    }
}
