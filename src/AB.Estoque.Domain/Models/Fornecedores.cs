using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB.Estoque.Domain.Models
{
    public class Fornecedores : Entity
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int CNPJ { get; set; }
        public int InscricaoEstadual { get; set; }
        public string Email { get; set; }
        public int Telfone { get; set; }

    }
}
