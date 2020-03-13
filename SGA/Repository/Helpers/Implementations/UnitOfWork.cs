using Microsoft.EntityFrameworkCore;
using Repository.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Helpers.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext dbcontext { get; }
        public UnitOfWork(DbContext context)
        {
            dbcontext = context;
        }
        public void Commit()
        {
            dbcontext.SaveChanges();
        }

        public void Dispose()
        {
            dbcontext.Dispose();
        }
    }
}
