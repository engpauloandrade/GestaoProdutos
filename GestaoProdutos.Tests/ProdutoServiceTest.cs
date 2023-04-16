using AutoMapper;
using GestaoProdutos.Application.Mapping;
using GestaoProdutos.Application.Services;
using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Model;
using GestaoProdutos.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace GestaoProdutos.Tests
{
    public class ProdutoServiceTest
    {
        private readonly ProdutoService _produtoService;
        private readonly ApiDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IPagedResultService<Produto> _pagedResultService;

        public ProdutoServiceTest()
        {
            var options = new DbContextOptionsBuilder<ApiDbContext>()
                .UseInMemoryDatabase(databaseName: "TesteDB")
                .Options;

            this._dbContext = new ApiDbContext(options);

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingDTO());
            });

            this._mapper = mapperConfig.CreateMapper();

            this._pagedResultService = new PagedResultService<Produto>(_dbContext);

            this._produtoService = new ProdutoService(_mapper, _dbContext, _pagedResultService);
        }



        [Test]
        public async Task DeletaProduto_DeveRemoverProdutoDoBancoDeDados()
        {
            // Arrange
            string codigo = "123454";

            var produto = new Produto()
            {
                Codigo = codigo,
            };

            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();

            // Act
            var produtoDeletado = await _produtoService.DeletaProduto("123454");

            // Assert
            Assert.IsNotNull(produtoDeletado);
            Assert.That(produtoDeletado.Codigo, Is.EqualTo(codigo));
        }


        [Test]
        public async Task DeletaProdutos_DeveDarErroAoRemoverProdutoDoBancoDeDados()
        {
            // Arrange
            string codigo = "123454";

            var produto = new Produto()
            {
                Codigo = codigo,
            };

            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();

            // Assert
            var produtoDeletado = await _produtoService.DeletaProduto("323232");


            // Act
            Assert.IsNull(produtoDeletado);
        }


        [Test]
        public async Task GetPorCodigo_PegaUmProdutoDoBancoDeDados()
        {
            // Arrange
            string codigo = "123454";

            var produto = new Produto()
            {
                Codigo = codigo,
            };

            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();

            // Act
            var produtoFiltrado = await _produtoService.GetPorCodigo(codigo);

            // Assert
            Assert.IsNotNull(produtoFiltrado);
        }

        [Test]
        public async Task GetFiltrado_FiltraProdutosPorCaracteres()
        {
            // Arrange
            string Descricao = "Pratos de loucas";

            var produto = new Produto()
            {
                Descricao = Descricao,
            };

            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();

            // Act
            var produtoFiltrado = await _produtoService.GetFiltrado("pr", 1, 1);

            // Assert
            Assert.That(Descricao, Is.EqualTo(produtoFiltrado.FirstOrDefault()?.Descricao));

            // Clean up
            _dbContext.Produtos.Remove(produto);
            await _dbContext.SaveChangesAsync();

        }
    }
}
