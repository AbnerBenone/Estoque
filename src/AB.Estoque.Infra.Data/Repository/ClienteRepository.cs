using AB.Estoque.Domain.Interfaces;
using AB.Estoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AB.Estoque.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Clientes>, IClienteRepository
    {
        public Clientes ObterPorCpf(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }
        public Clientes ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        public IEnumerable<Clientes> ObterAtivos()
        {
            return Buscar(c => c.Ativo && !c.Excluido);
        }  

        public override void Remover(Guid Id)
        {
            var cliente = ObterPorId(Id);
            cliente.Excluir();

            Atualizar(cliente);
        }
    }
}
