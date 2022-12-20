using AB.Estoque.Domain.Interfaces;
using AB.Estoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AB.Estoque.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedores>, IFornecedorRepository
    {       

        public Fornecedores ObterPorCnpj(string cnpj)
        {
            return Buscar(f => f.CNPJ == cnpj).FirstOrDefault();
        }

        public Fornecedores ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }
        public IEnumerable<Fornecedores> ObterAtivos()
        {
            return Buscar(f => f.Ativo && !f.Excluido);
        }

        public override void Remover(Guid Id)
        {
            var fornecedor = ObterPorId(Id);
            fornecedor.Excluir();

            Atualizar(fornecedor);
        }

    }
}
