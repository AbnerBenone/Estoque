using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AB.Estoque.Application.ViewModel.Cliente
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o campo RG")]
        [MaxLength(7, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(7, ErrorMessage = "Mínimo {0} caracteres")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Fantasia")]
        [MaxLength(7, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(7, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        //Não sei se é pra deixar false ou não,
        //pensei em colocar um botão para dizer se o cliente tá ativo ou não.
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        public IEnumerable<EnderecoViewModel> Enderecos { get; set; }

    }
}
