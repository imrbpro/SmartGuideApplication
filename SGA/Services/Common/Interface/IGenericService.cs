using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Common.Interface
{
    public interface IGenericService<E>
    {
        void Add(E entity);
        void Delete(E entity);
        void Update(E entity);
        IEnumerable<E> GetAll();
        IQueryable<E> FindBy(System.Linq.Expressions.Expression<Func<E, bool>> predicate); 
    }
}
