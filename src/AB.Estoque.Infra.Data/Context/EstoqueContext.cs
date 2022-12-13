using AB.Estoque.Domain.Models;
using System;
using System.Collections.Generic;
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


            base.OnModelCreating(modelBuilder);
        }
    }
}
