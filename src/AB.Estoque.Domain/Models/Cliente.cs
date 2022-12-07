using System;
using System.Collections.Generic;

namespace AB.Estoque.Domain.Models
{
    public class Cliente : Entity
    {
        public string Name { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public int Telefone { get; set; }
        public string NomeFantasia { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
    }
}
