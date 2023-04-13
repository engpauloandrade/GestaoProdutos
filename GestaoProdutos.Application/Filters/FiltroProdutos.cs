using GestaoProdutos.Application.DTO;
using GestaoProdutos.Domain.Interfaces;

namespace GestaoProdutos.Application.Filters
{
    public class FiltroProdutos : IFiltro<ProdutoDTO>
    {

        public string? Descricao { get; set; } = string.Empty;
        public string? Codigo { get; set; } = string.Empty;

        public ProdutoDTO? Dado()
        {
            ProdutoDTO produto = new();

            if (!string.IsNullOrEmpty(this.Descricao))
            {
                produto.Descricao = this.Descricao;

            } else if (this.Codigo != null)
            {
                produto.Codigo = this.Codigo;
            }
            return produto;
        }
    }
}
