using GestaoProdutos.Domain.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Model
{
    public class Produto : Base
    {
        public string Codigo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public string Situacao { get; set; } = string.Empty;
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int FornecedorCodigo { get; set; }
        public string FornecedorDescricao { get; set; } = string.Empty;
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}
