using AB.Estoque.Application.Interfaces;
using AB.Estoque.Application.ViewModel.Fornecedor;
using AB.Estoque.Application.ViewModel.Produto;
using AB.Estoque.Domain.Interfaces;
using AB.Estoque.Domain.Models;
using AB.Estoque.Infra.Data.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;


namespace AB.Estoque.Application.Services
{
    public class ProdutoAppService : IProdutosAppService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public FornecedorProdutoViewModel Adicionar(FornecedorProdutoViewModel fornecedorProdutoViewModel)
        {
            var produto = Mapper.Map<Produtos>(fornecedorProdutoViewModel.Produto);
            _produtoRepository.Adicionar(produto);

            return fornecedorProdutoViewModel;

        }

        public ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel)
        {
            var produto = Mapper.Map<Produtos>(produtoViewModel);
            _produtoRepository.Atualizar(produto);

            return produtoViewModel;
        }      

        public IEnumerable<ProdutoViewModel> ObterAtivos()
        {
            return Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.ObterAtivos());
        }

        public ProdutoViewModel ObterPorCategoria(string categoria)
        {
            return Mapper.Map<ProdutoViewModel>(_produtoRepository.ObterPorCategoria(categoria));
        }

        public ProdutoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ProdutoViewModel>(_produtoRepository.ObterPorId(id));
        }

        public IEnumerable<ProdutoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _produtoRepository.Remover(id);
        }
        public void Dispose()
        {
            _produtoRepository.Dispose();
        }
    }
}
