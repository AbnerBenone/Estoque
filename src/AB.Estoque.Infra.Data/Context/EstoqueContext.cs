using AB.Estoque.Domain.Models;
using AB.Estoque.Infra.Data.EntityConfig;
using AB.Estoque.Infra.Data.EntityConfig.Fornecedores;
using AB.Estoque.Infra.Data.EntityConfig.Produtos;
using AB.Estoque.Infra.Data.EntityConfig.Vendas;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AB.Estoque.Infra.Data.Context
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Vendas> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new FornecedoresConfig());
            modelBuilder.Configurations.Add(new ProdutosConfig());
            modelBuilder.Configurations.Add(new VendasConfig());


            base.OnModelCreating(modelBuilder);
        }
    }
}
