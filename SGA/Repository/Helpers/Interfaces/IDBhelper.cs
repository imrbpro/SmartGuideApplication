using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Helpers.Interfaces
{
    public interface IDBhelper
    {
        Task<DataTable> Get(string sp, DbParameter[] parameters);
        Task<DataTable> Get(string query);
        bool ExecuteNonQuery(string sp, DbParameter[] parameters);
        bool ExecuteNonQuery(string query);
        void Dispose();
        void RollbackTransaction();

    }
}
