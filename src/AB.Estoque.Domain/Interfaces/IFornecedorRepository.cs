using AB.Estoque.Domain.Models;
using System.Collections.Generic;


namespace AB.Estoque.Domain.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedores>
    {
        Fornecedores ObterPorCnpj(string cnpj);
        Fornecedores ObterPorEmail(string email);
        IEnumerable<Fornecedores> ObterAtivos();
    }
}
