using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Helpers.Interfaces
{
    public interface IDBhelper
    {
        Task<DataTable> Get(string sp, SqlParameter[] parameters);
        Task<DataTable> Get(string query);
        string GetBy(string sp, SqlParameter[] parameters);
        bool ExecuteNonQuery(string sp, SqlParameter[] parameters);
        bool ExecuteNonQuery(string query);
        void Dispose();
        void RollbackTransaction();

    }
}
