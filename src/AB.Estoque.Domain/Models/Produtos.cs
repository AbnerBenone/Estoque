using System;
using System.Collections.Generic;

namespace AB.Estoque.Domain.Models
{
    public class Produtos :Entity
    {
        public string Name { get; set; }
        public string Categoria { get; set; }
        public int QuantEstoque { get; set; }
        public int ValorCusto { get; set; }
        public int ValorRevenda { get; set; }
        public DateTime DataCadastro { get; set; }

        public Produtos()
        {
                
        }

        public Produtos(string name, string categoria, int quantEstoque, int valorCusto, int valorRevenda, DateTime dataCadastro)
        {
            Name = name;
            Categoria = categoria;
            QuantEstoque = quantEstoque;
            ValorCusto = valorCusto;
            ValorRevenda = valorRevenda;
            DataCadastro = dataCadastro;
        }

        public void AdicionarProduto(int quantidade)
        {
            QuantEstoque += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            QuantEstoque -= quantidade;
        }

       
    }
}
