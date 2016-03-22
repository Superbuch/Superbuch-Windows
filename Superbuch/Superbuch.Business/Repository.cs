using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Superbuch.Contracts;

namespace Superbuch.Business
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        public IDataContext DataContext { get; set; }

        protected Repository(IDataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

    }
}
