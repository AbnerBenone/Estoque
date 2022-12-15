using AB.Estoque.Domain.Models;
using System.Data.Entity.ModelConfiguration;


namespace AB.Estoque.Infra.Data.EntityConfig.Produtos
{
    public class ProdutosConfig : EntityTypeConfiguration<Produtos>
    {
        public ProdutosConfig()
        {
            HasKey(p => p.Id).IsRequired();

           

        }
    }
}
