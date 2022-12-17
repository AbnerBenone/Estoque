using AB.Estoque.Application.Interfaces;
using AB.Estoque.Application.ViewModel.Cliente;
using AB.Estoque.Domain.Interfaces;
using AB.Estoque.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AB.Estoque.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteAppService()
        {
            _clienteRepository = new ClienteRepository();    
        }

        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ObterAtivos()
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
