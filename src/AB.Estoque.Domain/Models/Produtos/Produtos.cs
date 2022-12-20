using System;

namespace AB.Estoque.Domain.Models
{
    public class Produtos : Entity
    {
        public string Name { get; set; }
        public string Categoria { get; set; }
        public string QuantEstoque { get; set; }
        public string ValorCusto { get; set; }
        public string ValorRevenda { get; set; }
        public DateTime DataCadastro { get; set; }
        public Guid FornecedoresId { get; set; }
        public virtual Fornecedores Fornecedores { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }

        public Produtos()
        {
                
        }

        public Produtos(string name, string categoria, string quantEstoque,
            string valorCusto, string valorRevenda, DateTime dataCadastro, bool ativo, bool excluido)
        {
            Name = name;
            Categoria = categoria;
            QuantEstoque = quantEstoque;
            ValorCusto = valorCusto;
            ValorRevenda = valorRevenda;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            Excluido = excluido;
        }

        public void AdicionarProduto(int quantidade)
        {
            QuantEstoque += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            QuantEstoque.Remove(quantidade);
        }
        public void Excluir()
        {
            Ativo = true;
            Excluido = false;
        }


    }
}
