using AB.Estoque.Application.ViewModel.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AB.Estoque.Application.ViewModel.Fornecedor
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Razão Social")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Fantasia")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Preencha o campo Inscrição Estadual")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string InscricaoEstadual { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Telefone { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        public IEnumerable<ProdutoViewModel> Produto { get; set; }
    }
}
