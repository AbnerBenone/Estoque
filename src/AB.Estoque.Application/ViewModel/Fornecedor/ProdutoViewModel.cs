using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB.Estoque.Application.ViewModel.Produto
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Categoria")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Preencha o campo Quantidade em estoque")]
        [DisplayName("Estoque Atual")]
        public string QuantEstoque { get; set; }

        [Required(ErrorMessage = "Preencha o campo Valor de custo")]
        [DisplayName("Custo")]
        public string ValorCusto { get; set; }

        [Required(ErrorMessage = "Preencha o campo Valor de revenda")]
        [DisplayName("Revenda")]
        public string ValorRevenda { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

        [ScaffoldColumn(false)]
        public Guid FornecedoresId { get; set; }

    }
}
