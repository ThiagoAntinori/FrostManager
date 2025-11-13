using DAL.Contracts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SqlConnection _connection;
        private SqlTransaction _transaction;

        public SqlConnection Connection { get => _connection; }
        public SqlTransaction Transaction { get => _transaction; set => _transaction = value; }

        public UnitOfWork()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BusinessConString"].ConnectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            _transaction?.Commit();
            Dispose();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _connection?.Close();
            _connection?.Dispose();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
            Dispose();
        }
    }
}
