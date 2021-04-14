using EtsyBusinessMetricsAPI.Models;
using EtsyBusinessMetricsAPI.HelperMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EtsyBusinessMetricsAPI.DataAcess
{
    public class PurchaseDataAccess : IPurchaseDataAccess
    {
        private readonly string connectionString;
        DataAccessHelper helper = new DataAccessHelper();
        public PurchaseDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public decimal GetTotalPurchases()
        {
            List<decimal> purchases = new List<decimal>();
            const string query = @"SELECT b.SupplyCost FROM Purchase a " +
                                "Join Supply b on a.SupplyId=b.SupplyId";
            decimal sum = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    purchases.Add(Convert.ToDecimal(rdr["SupplyCost"]));
                }

            }

            foreach (decimal item in purchases)
            {
                sum += item;
            }

            return sum;
        }

        public List<DetailedPurchase> GetAllPurchases()
        {
            List<DetailedPurchase> purchases = new List<DetailedPurchase>();
            const string query = @"SELECT PurchaseId,PurchaseDate,a.SupplyId,SupplyName,SupplyType,SupplyCost FROM Purchase a"
                                   + " Join Supply b on a.SupplyId=b.SupplyId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    purchases.Add(PurchaseDataAdpater(rdr));
                }
            }



            return purchases;
        }

        public void UpdatePurchase(UpdatePurchase purchase)
        {
            const string query = @"UPDATE Purchase SET SupplyId = @supplyId WHERE PurchaseId = @purchaseId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@supplyId", purchase.SupplyId);
                    cmd.Parameters.AddWithValue("@purchaseId", purchase.PurchaseId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.Message); ;
            }
        }

        public void CreatePurchase(CreatePurchase purchase)
        {
            const string query = @"INSERT Purchase (PurchaseDate, SupplyId) VALUES (@purchaseDate, @supplyId)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@supplyId", purchase.SupplyId);
                    cmd.Parameters.AddWithValue("@purchaseDate", purchase.purchaseDate);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }

        private DetailedPurchase PurchaseDataAdpater(SqlDataReader reader)
        {
            DetailedPurchase purchase = new DetailedPurchase();

            purchase.PurchaseId = Convert.ToInt32(reader["PurchaseId"]);
            purchase.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]);
            purchase.SupplyId = Convert.ToInt32(reader["SupplyId"]);
            purchase.SupplyName = Convert.ToString(reader["SupplyName"]);
            purchase.SupplyType = Convert.ToString(reader["SupplyType"]);
            purchase.SupplyCost = Convert.ToDecimal(reader["SupplyCost"]);

            return purchase;
        }
    }
}
