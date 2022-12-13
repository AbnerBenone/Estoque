using System;
using System.Collections.Generic;

namespace AB.Estoque.Domain.Models
{
    public class Clientes : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Enderecos> Enderecos { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public int Telefone { get; set; }
        public string NomeFantasia { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }

        public Clientes()
        {
            Enderecos = new List<Enderecos>();     
        }

        public Clientes(string name, string email, int cpf, int rg, int telefone, string nomeFantasia, DateTime dataNascimento, DateTime dataCadastro, bool ativo, bool excluido)
        {
            Name = name;
            Email = email;
            CPF = cpf;
            RG = rg;
            Telefone = telefone;
            NomeFantasia = nomeFantasia;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            Excluido = excluido;
        }

        public void AdicionarCliente()
        {

        }

        public void RemoverCliente()
        {

        }
    }
}
