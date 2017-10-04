using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DigitalentCoreApp.Domain.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {

        // TODO::: Repository Pattern async
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity GetById(object id);
        void Add(TEntity entityToAdd);
        void Update(TEntity entityToUpdate);
        void Remove(object id);

        IEnumerable<TEntity> GetAll();
    }
}
