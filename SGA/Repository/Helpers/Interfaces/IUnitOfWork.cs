using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Helpers.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        DbContext dbcontext { get; }
        void Commit();
    }
}
