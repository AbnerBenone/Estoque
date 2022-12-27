using AB.Estoque.Application.ViewModel.Fornecedor;
using System;
using System.Collections.Generic;

namespace AB.Estoque.Application.Interfaces
{
    public interface IFornecedoresAppService : IDisposable
    {
        FornecedorProdutoViewModel Adicionar(FornecedorProdutoViewModel fornecedorProdutoViewModel);
        FornecedorViewModel ObterPorId(Guid id);
        IEnumerable<FornecedorViewModel> ObterTodos();
        IEnumerable<FornecedorViewModel> ObterAtivos();
        FornecedorViewModel ObterPorCnpj(string cnpj);
        FornecedorViewModel ObterPorEmail(string email);
        FornecedorViewModel Atualizar(FornecedorViewModel clienteViewModel);
        void Remover(Guid id);

    }
}
