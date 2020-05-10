using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CorporateBackend.Core.Entities;

namespace CorporateBackend.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetAllQueryable(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);
        T GetById(object id);

        T Insert(T entity);
        T Update(T entity);
        T Delete(T entity);
        void Delete(object id);
    }
}