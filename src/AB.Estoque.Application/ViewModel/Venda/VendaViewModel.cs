using AB.Estoque.Application.ViewModel.Cliente;
using AB.Estoque.Application.ViewModel.Fornecedor;
using AB.Estoque.Application.ViewModel.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AB.Estoque.Application.ViewModel.Venda
{
    public class VendaViewModel
    {
        //Não sei o que fazer aqui!!

        public VendaViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public IEnumerable<ClienteViewModel> Clientes { get; set; }
        public IEnumerable<EnderecoViewModel> Enderecos { get; set; }
        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
