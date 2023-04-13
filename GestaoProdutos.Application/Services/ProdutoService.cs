using AutoMapper;
using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using System.Linq.Expressions;

namespace GestaoProdutos.Application.Services
{
    public class ProdutoService
    {
        private readonly IMapper _mapper;

        public ProdutoService( IMapper mapper)
        {
            this._mapper = mapper;
        }

    }
}
