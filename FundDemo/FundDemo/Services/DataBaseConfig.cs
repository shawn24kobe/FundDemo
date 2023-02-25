using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FundDemo.Services
{
    public class DataBaseConfig
    {
        private static string DefaultSqlConnectionString = string.Empty;
        public static IDbConnection GetSqlConnection(string sqlConnectionString = null)
        {
            if (string.IsNullOrWhiteSpace(sqlConnectionString))
            {
                sqlConnectionString = DefaultSqlConnectionString;
            }
            IDbConnection conn = new SqlConnection(sqlConnectionString);
            conn.Open();
            return conn;
        }

        public static void GetDbConnStr(string conn)
        {
            DefaultSqlConnectionString = conn;
        }
    }
}
