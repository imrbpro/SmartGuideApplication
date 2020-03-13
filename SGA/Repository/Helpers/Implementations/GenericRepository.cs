using Microsoft.EntityFrameworkCore;
using Repository.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Helpers.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IUnitOfWork unitOfWork;
        public GenericRepository(IUnitOfWork unit)
        {
            unitOfWork = unit;
        }
        public void Add(T entity)
        {
            unitOfWork.dbcontext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            T existing = unitOfWork.dbcontext.Set<T>().Find(entity);
            if (existing != null) unitOfWork.dbcontext.Set<T>().Remove(existing);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> response = unitOfWork.dbcontext.Set<T>().Where(predicate).AsNoTracking();
            return response;
        }

        public IEnumerable<T> Get()
        {
            return unitOfWork.dbcontext.Set<T>().AsNoTracking();
        }

        public void Update(T entity)
        {
            unitOfWork.dbcontext.Entry(entity).State = EntityState.Modified;
            unitOfWork.dbcontext.Set<T>().Update(entity);
        }
    }
}
