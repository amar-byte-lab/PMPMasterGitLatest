using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace CabconPMP.Data
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }

    public class LocalDbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public LocalDbConnectionFactory(string dbPath = null)
        {
            string mdfPath = dbPath ?? Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "AemCalData.mdf"
            );

            _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={mdfPath};Integrated Security=True;Connect Timeout=30;";
        }

        public IDbConnection CreateConnection()
        {
            var conn = new SqlConnection(_connectionString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }
    }

    public class SqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public SqlConnectionFactory()
        {
            _connectionString =
                @"Server=DESKTOP-20HU07J\SQLEXPRESS;
              Database=AemCalData;
              Integrated Security=True;
              TrustServerCertificate=True;
              Encrypt=False;";
        }

        public IDbConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}