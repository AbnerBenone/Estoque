using AB.Estoque.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AB.Estoque.Infra.Data.EntityConfig
{
    public class FornecedoresConfig : EntityTypeConfiguration<Fornecedores>
    {
        public FornecedoresConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.RazaoSocial).IsRequired().HasMaxLength(150);
            Property(f => f.NomeFantasia).IsRequired().HasMaxLength(150);
            Property(f => f.CNPJ).IsRequired().HasMaxLength(14).IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CNPJ")
                { IsUnique = true }));

            Property(f => f.InscricaoEstadual).IsRequired().HasMaxLength(9).IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_IE")
                { IsUnique = true }));

            Property(f => f.Email).IsRequired().HasMaxLength(100);
            Property(f => f.Telefone).IsRequired();
            Property(f => f.Ativo).IsRequired();
            Property(f => f.Excluido).IsRequired();

            ToTable("Fornecedores");

        }
    }
}
