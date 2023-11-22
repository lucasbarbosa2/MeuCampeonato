using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class Seed
    {
        private static IDbConnection _dbConnection;

        public static void CreateDb(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqlConnection");
            var dbFilePath = configuration.GetConnectionString("SqlConnection");
            if (!File.Exists(dbFilePath))
            {
                _dbConnection = new SqlConnection(connectionString);
                _dbConnection.Open();

                // Create a Product table
                _dbConnection.Execute(@"
                    CREATE TABLE IF NOT EXISTS [Product] (
                        [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        [Name] NVARCHAR(128) NOT NULL,
                        [Quantity] INTEGER NULL,
                        [Price] NUMERIC NOT NULL
                    )");

                _dbConnection.Close();
            }

        }
    }
}
