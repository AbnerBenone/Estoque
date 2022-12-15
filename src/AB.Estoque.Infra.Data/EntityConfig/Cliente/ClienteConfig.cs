using AB.Estoque.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;


namespace AB.Estoque.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Clientes>
    {
        public ClienteConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(150);

            Property(c => c.CPF).IsRequired().HasMaxLength(11).IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CPF")
                { IsUnique = true }));

            Property(c => c.Email).IsRequired().HasMaxLength(100);

            Property(c => c.RG).IsRequired().HasMaxLength(7).IsMaxLength()
            .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_RG")
            { IsUnique = true }));

            Property(c => c.Telefone).IsRequired();
            Property(c => c.NomeFantasia).IsRequired();
            Property(c => c.DataNascimento).IsRequired();
            Property(c => c.Ativo).IsRequired();
            Property(c => c.Excluido).IsRequired();

            ToTable("Clientes");
        } 
    }
}
