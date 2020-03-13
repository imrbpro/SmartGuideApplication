using Repository.Helpers.Interfaces;
using Services.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services.Common.Implementation
{
    public class GenericService<E> : IGenericService<E> where E : class
    {
        public IUnitOfWork UnitOfWork { get;  set; }
        public IGenericRepository<E> genericRepository { get; set; }
        public void Add(E entity)
        {
            genericRepository.Add(entity);
            UnitOfWork.Commit();
        }

        public void Delete(E entity)
        {
            genericRepository.Delete(entity);
            UnitOfWork.Commit();
        }

        public IQueryable<E> FindBy(Expression<Func<E, bool>> predicate)
        {
            return genericRepository.FindBy(predicate);
        }

        public IEnumerable<E> GetAll()
        {
            return genericRepository.Get();
        }

        public void Update(E entity)
        {
            throw new NotImplementedException();
        }
    }
}
