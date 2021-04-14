using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EtsyBusinessMetricsAPI.Models;

namespace EtsyBusinessMetricsAPI.DataAcess
{
    public class SaleDataAcess : ISaleDataAcess
    {
        private readonly string connectionString;
        public SaleDataAcess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Sale> GetAllSales()
        {
            List<Sale> sales = new List<Sale>();

            string query = @"SELECT * FROM EtsySale";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        sales.Add(SaleDataAdpater(rdr));
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return sales;
        }

        public decimal GetSumOfSales()
        {
            List<Sale> sales = new List<Sale>();
            decimal sum = 0;
            string query = @"SELECT * FROM EtsySale";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        sales.Add(SaleDataAdpater(rdr));
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            foreach (Sale sale in sales)
            {
                sum += sale.SaleAmount;
            }
            return sum;
        }

        private Sale SaleDataAdpater(SqlDataReader reader)
        {
            Sale sale = new Sale();

            sale.OrderId= Convert.ToInt64(reader["Orderid"]);
            sale.SaleAmount = Convert.ToDecimal(reader["SaleAmount"]);
            sale.Status = Convert.ToString(reader["Status"]);
            sale.OrderDate = Convert.ToDateTime(reader["OrderDate"]);

            return sale;
        }

    }
}
