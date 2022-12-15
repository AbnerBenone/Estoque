using AB.Estoque.Application.ViewModel.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB.Estoque.Application.ViewModel.Fornecedor
{
    public class FornecedorProdutoViewModel
    {
        public FornecedorViewModel Fornecedor { get; set; }
        public ProdutoViewModel Produto { get; set; }
    }
}
