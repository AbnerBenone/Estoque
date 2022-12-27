using AB.Estoque.Application.Interfaces;
using AB.Estoque.Application.ViewModel.Fornecedor;
using AB.Estoque.Domain.Interfaces;
using AB.Estoque.Domain.Models;
using AB.Estoque.Infra.Data.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AB.Estoque.Application.Services
{
    public class FornecedorAppService : IFornecedoresAppService
    {

        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorAppService()
        {
            _fornecedorRepository = new FornecedorRepository();
        }


        public FornecedorProdutoViewModel Adicionar (FornecedorProdutoViewModel fornecedorProdutoViewModel)
        {
            var fornecedor = Mapper.Map<Fornecedores>(fornecedorProdutoViewModel.Fornecedor);
            _fornecedorRepository.Adicionar(fornecedor);

            return fornecedorProdutoViewModel;
        }

        public FornecedorViewModel Atualizar(FornecedorViewModel fornecedorViewModel)
        {
            var cliente = Mapper.Map<Fornecedores>(fornecedorViewModel);
            _fornecedorRepository.Atualizar(cliente);

            return fornecedorViewModel;
        }      

        public IEnumerable<FornecedorViewModel> ObterAtivos()
        {
            return Mapper.Map<IEnumerable<FornecedorViewModel>>(_fornecedorRepository.ObterAtivos());
        }

        public FornecedorViewModel ObterPorCnpj(string cnpj)
        {
            return Mapper.Map<FornecedorViewModel>(_fornecedorRepository.ObterPorCnpj(cnpj));
        }

        public FornecedorViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<FornecedorViewModel>(_fornecedorRepository.ObterPorEmail(email));
        }

        public FornecedorViewModel ObterPorId(Guid Id)
        {
            return Mapper.Map<FornecedorViewModel>(_fornecedorRepository.ObterPorId(Id));
        }

        public IEnumerable<FornecedorViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<FornecedorViewModel>>(_fornecedorRepository.ObterTodos());
        }

        public void Remover(Guid Id)
        {
            _fornecedorRepository.Remover(Id);
        }

        public void Dispose()
        {
            _fornecedorRepository.Dispose();
        }
    }
}
