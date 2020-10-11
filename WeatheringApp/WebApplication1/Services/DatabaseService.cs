using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace WebApplication1.Services
{
    public class DatabaseService
    {
        static void ConnectToDatabase()
        {
            string connStr = "server=127.0.0.1, 3306; uid=root; pwd=root; database=weatheringapp";

            MySqlConnection connection = new MySqlConnection(connStr);

            using (connection)
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error connectiong to database: " + ex.Message + "\n");
                    throw ex;
                }
            }

            //Maybe use try/catch/finally, closing the connection in the finally block instead of using()
        }


        static DataSet ExecuteQuery()
        {
            DataSet ds = new DataSet();

            ConnectToDatabase();

            return ds;
        }
    }

}
