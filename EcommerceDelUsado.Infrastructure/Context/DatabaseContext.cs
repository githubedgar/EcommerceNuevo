
// Ruta: EcommerceDelUsado.Infrastructure/Context/DatabaseContext.cs

using Microsoft.Data.SqlClient;
using System.Data;
using EcommerceDelUsado.Application.Common.Interfaces;

namespace EcommerceDelUsado.Infrastructure.Context
{
    public class DatabaseContext : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
