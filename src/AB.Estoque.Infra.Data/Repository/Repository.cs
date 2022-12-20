using AB.Estoque.Domain.Interfaces;
using AB.Estoque.Domain.Models;
using AB.Estoque.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace AB.Estoque.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected EstoqueContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new EstoqueContext();
            DbSet = Db.Set<TEntity>();
        }
        public virtual TEntity Adicionar(TEntity obj)
        {
            var retEnt = DbSet.Add(obj);
            SaveChanges();
            return retEnt;
        }          
        
        public virtual TEntity ObterPorId(Guid Id)
        {
            return DbSet.Find(Id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> ObterTodosPaginado(int s, int t)
        {
            return DbSet.Skip(s).Take(t).ToList();
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();

            return obj;
        }
        public virtual void Remover(Guid Id)
        {
            var obj = new TEntity() {Id = Id};
            DbSet.Remove(obj);
            SaveChanges();
        }
        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
