using Microsoft.Extensions.Configuration;
using Repository.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Helpers.Implementations
{
    public class Dbhelper : IDBhelper
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;
        private readonly string _connectionString;
        public Dbhelper(IConfiguration config)
        {
            _configuration = config;
            _connectionString = _configuration.GetConnectionString("Db");
            _connection = new SqlConnection(_connectionString);
        }

        public void Dispose()
        {
            _connection.Close();
        }

        public bool ExecuteNonQuery(string sp, DbParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public bool ExecuteNonQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Get(string sp, DbParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Get(string query)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string tblName, DataTable data)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string sp, DbParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
