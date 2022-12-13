using System.Data.Entity.Migrations;
using AB.Estoque.Infra.Data.Context;


namespace AB.Estoque.Infra.Data.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<EstoqueContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AB.Estoque.Infra.Data.Context.EstoqueContext context)
        {
            
        }
    }
}
