using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
    
namespace ConexionSQL
{
    public class ConexionSQL
    {
        public static string connectionString = "Data Source=.;Initial Catalog=FastFood;Integrated Security=True";

        public static DataTable FillData(string comandoSql)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSql, sqlConnection);
                    sqlDataAdapter.Fill(dataTable);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dataTable;
        }
    }  
}