using AB.Estoque.Domain.Interfaces;
using AB.Estoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AB.Estoque.Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produtos>, IProdutoRepository
    {        
        public Produtos ObterPorCategoria(string categoria)
        {
            return Buscar(p => p.Categoria == categoria).FirstOrDefault();
        }
        public IEnumerable<Produtos> ObterAtivos()
        {
            return Buscar(f => f.Ativo && !f.Excluido);
        }

        public override void Remover(Guid Id)
        {
            var produto = ObterPorId(Id);
            produto.Excluir();

            Atualizar(produto);
        }
     
    }
}
