using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Helpers.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

    }
}
