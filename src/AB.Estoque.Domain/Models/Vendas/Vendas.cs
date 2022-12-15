using System;
using System.Collections.Generic;

namespace AB.Estoque.Domain.Models
{
    public class Vendas : Entity
    {
        public ICollection<Clientes> Cliente { get; set; }
        public ICollection<Produtos> Produto { get; set; }
        public DateTime DataVenda { get; set; }

        public Vendas()
        {
               
        }

        public Vendas(DateTime dataVenda)
        {
            DataVenda = dataVenda;
        }

    }
}
