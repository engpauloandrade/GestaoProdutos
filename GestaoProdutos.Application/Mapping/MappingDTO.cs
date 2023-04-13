using AutoMapper;
using GestaoProdutos.Application.DTO;
using GestaoProdutos.Domain.Model;

namespace GestaoProdutos.Application.Mapping
{
    public class MappingDTO : Profile
    {
        public MappingDTO() : base()
        {
            MapeamentoOrder();
        }

        private void MapeamentoOrder()
        {
            CreateMap<ProdutoDTO, Produto>().ReverseMap();
        }

    }
}
