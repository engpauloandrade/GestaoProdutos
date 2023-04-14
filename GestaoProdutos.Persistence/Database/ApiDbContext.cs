using Bogus;
using GestaoProdutos.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace GestaoProdutos.Persistence.Database
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasData(getProductSeed());
        }
        public DbSet<Produto> Produtos { get; set; }

        private Produto [] getProductSeed()
        {
            List<Produto> result = new();
            for (int i = 0; i < 50; i++)
            {
                result.Add(new Produto()
                {
                    Id = i + 1,
                    Codigo = new Faker().Random.ReplaceNumbers("###############"),
                    Descricao = new Faker().Commerce.ProductName(),
                    Situacao = new Faker().PickRandom("Ativo", "Inativo"),
                    DataFabricacao = new Faker().Date.Past(),
                    DataValidade = new Faker().Date.Future(),
                    FornecedorCodigo = new Faker().Random.Int(1, 2000),
                    FornecedorDescricao = new Faker().Company.CompanyName(),
                    FornecedorCnpj = new Faker().Random.ReplaceNumbers("########0001"),
                    Quantidade = new Faker().Random.Int(1, 100)
                });
            }
            return result.ToArray();
        }
    }
}
