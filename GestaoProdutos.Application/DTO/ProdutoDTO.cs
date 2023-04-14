using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GestaoProdutos.Application.DTO
{
    public class ProdutoDTO
    {
        [Required(ErrorMessage = "O código do produto é obrigatório")]
        [JsonPropertyName("productCod")]
        public string Codigo { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição do produto é obrigatória")]
        [JsonPropertyName("productDescription")]
        public string Descricao { get; set; } = string.Empty;


        [Required(ErrorMessage = "A situação do produto é obrigatória")]
        [JsonPropertyName("productStatus")]
        public string Situacao { get; set; } = string.Empty;

        [Required(ErrorMessage = "A daata de fabricação do produto é obrigatória")]
        [JsonPropertyName("manufacturingDate")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "A data de validade do produto é obrigatória")]
        [JsonPropertyName("expirationDate")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "O código do fornecedor é obrigatório")]
        [JsonPropertyName("providerCode")]
        public int FornecedorCodigo { get; set; }

        [Required(ErrorMessage = "A quantidade do produto é obrigatória")]
        [JsonPropertyName("quantity")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "A descrição do fornecedor é obrigatória")]
        [JsonPropertyName("providerDescription")]
        public string FornecedorDescricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O cnpj do fornecedor é obrigatórios")]
        [JsonPropertyName("providerCnpj")]
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}
