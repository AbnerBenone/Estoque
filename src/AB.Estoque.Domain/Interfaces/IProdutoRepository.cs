using AB.Estoque.Domain.Models;
using System.Collections.Generic;

namespace AB.Estoque.Domain.Interfaces
{
    public interface IProdutoRepository : IRepository<Produtos>
    {
        Produtos ObterPorCategoria(string categoria);
        IEnumerable<Produtos> ObterAtivos();
    

    }
}
