using System;
using System.Collections.Generic;

namespace AB.Estoque.Domain.Models
{
    public class Enderecos : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }        
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public Guid ClienteId { get; set; }
        public virtual Clientes Cliente { get; set; }

        public Enderecos()
        {
                
        }

        public Enderecos(string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }
    }
}
