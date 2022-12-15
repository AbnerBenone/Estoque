using AB.Estoque.Domain.Models;
using System.Collections.Generic;


namespace AB.Estoque.Domain.Interfaces
{
    public interface IClienteRepository : IRepository<Clientes>
    {
        Clientes ObterPorCpf(string cpf);
        Clientes ObterPorEmail(string email);
        IEnumerable<Clientes> ObterAtivos();

    }
}
