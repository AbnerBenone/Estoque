using System.Collections.Generic;

namespace AB.Estoque.Domain.Models
{
    public class Fornecedores : Entity
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }

        public Fornecedores()
        {
            Produtos = new List<Produtos>();
        }
        public void Excluir()
        {
            Ativo = true;
            Excluido = false;
        }

    }
}
