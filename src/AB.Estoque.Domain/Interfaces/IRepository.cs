using AB.Estoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AB.Estoque.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(Guid Id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterTodosPaginado(int s, int t);
        TEntity Atualizar(TEntity obj);
        void Remover(Guid Id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
