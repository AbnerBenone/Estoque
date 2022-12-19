using AB.Estoque.Domain.Models;
using System.Data.Entity.ModelConfiguration;


namespace AB.Estoque.Infra.Data.EntityConfig
{
    public class ProdutosConfig : EntityTypeConfiguration<Produtos>
    {
        public ProdutosConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Name).IsRequired().HasMaxLength(150);
            Property(p => p.Categoria).IsRequired().HasMaxLength(100);
            Property(p => p.QuantEstoque).IsRequired();
            Property(p => p.ValorCusto).IsRequired();
            Property(p => p.ValorRevenda).IsRequired();
            Property(p => p.Ativo).IsRequired();
            Property(p => p.Excluido).IsRequired();

            HasRequired(p => p.Fornecedores).WithMany(f => f.Produtos).HasForeignKey(p => p.FornecedoresId);

            ToTable("Produtos");

        }
    }
}
