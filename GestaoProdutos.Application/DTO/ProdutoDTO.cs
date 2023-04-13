using System.Text.Json.Serialization;

namespace GestaoProdutos.Application.DTO
{
    public class ProdutoDTO
    {
        [JsonPropertyName("productCod")]
        public string Codigo { get; set; } = string.Empty;

        [JsonPropertyName("productDescription")]
        public string Descricao { get; set; } = string.Empty;

        [JsonPropertyName("productStatus")]
        public string Situacao { get; set; } = string.Empty;

        [JsonPropertyName("manufacturingDate")]
        public DateTime DataFabricacao { get; set; }

        [JsonPropertyName("expirationDate")]
        public DateTime DataValidade { get; set; }

        [JsonPropertyName("providerCode")]
        public int FornecedorCodigo { get; set; }

        [JsonPropertyName("providerDescription")]
        public string FornecedorDescricao { get; set; } = string.Empty;

        [JsonPropertyName("providerCnpj")]
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}
