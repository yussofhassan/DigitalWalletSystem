using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace welllet.Classes
{
    internal class DatabaseManager
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=DigitalWalletDB;
              Integrated Security=True";

        SqlConnection connection;

        public DatabaseManager()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}