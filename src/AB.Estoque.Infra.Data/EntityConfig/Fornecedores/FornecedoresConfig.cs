using AB.Estoque.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace AB.Estoque.Infra.Data.EntityConfig.Fornecedores
{
    public class FornecedoresConfig : EntityTypeConfiguration<Fornecedores>
    {
        public FornecedoresConfig()
        {
            HasKey(f => f.Id);
        }
    }
}
