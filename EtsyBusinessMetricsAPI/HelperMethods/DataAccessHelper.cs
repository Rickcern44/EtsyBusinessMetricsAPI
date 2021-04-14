using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EtsyBusinessMetricsAPI.HelperMethods
{
    public class DataAccessHelper
    {
        public SqlDataReader DataHelper(string query, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                return rdr;
            }
        }
    }
}
