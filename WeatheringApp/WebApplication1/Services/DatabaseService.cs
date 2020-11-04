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

        static string QueryBuilder()
        {

            //1º extract (API) and transform (ETL) data
            //2º Create paramList (Using db types)
            //3º Assign values ro the values in the paramlist
            //4º Create query using stringBuilder or similar, create Insert syntax + values taken from the param list

            return null;
        }

        static DataSet ExecuteQuery()
        {

            string connStr = "server=127.0.0.1, 3306; uid=root; pwd=root; database=weatheringapp";

            MySqlConnection connection = new MySqlConnection(connStr);

            DataSet ds = new DataSet();

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

            return ds;
        }

        static void ExecuteNonQuery(string query)
        {
            string connStr = "server=127.0.0.1, 3306; uid=root; pwd=root; database=weatheringapp";

            MySqlConnection connection = new MySqlConnection(connStr);

            // string query = QueryBuilder();

            using (connection)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error connectiong to database: " + ex.Message + "\n");
                    throw ex;
                }
            }

        }
    }

}
