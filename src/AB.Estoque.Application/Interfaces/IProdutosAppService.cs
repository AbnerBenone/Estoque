using AB.Estoque.Application.ViewModel.Fornecedor;
using AB.Estoque.Application.ViewModel.Produto;
using System;
using System.Collections.Generic;

namespace AB.Estoque.Application.Interfaces
{
    public interface IProdutosAppService : IDisposable
    {
        FornecedorProdutoViewModel Adicionar(FornecedorProdutoViewModel fornecedorProdutoViewModel);
        ProdutoViewModel ObterPorId(Guid id);
        IEnumerable<ProdutoViewModel> ObterTodos();
        IEnumerable<ProdutoViewModel> ObterAtivos();
        ProdutoViewModel ObterPorCategoria(string categoria);
        ProdutoViewModel Atualizar(ProdutoViewModel clienteViewModel);
        void Remover(Guid id);
    }
}
