using EtsyBusinessMetricsAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace EtsyBusinessMetricsAPI.DataAcess
{
    public class SupplyDataAccess : ISupplyDataAccess
    {

        private readonly string connectionString;
        public SupplyDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Supply> GetAllSupplies()
        {
            List<Supply> supplies = new List<Supply>();
            const string query = @"SELECT * FROM Supply";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    supplies.Add(SupplyDataAdapter(rdr));
                }
            }

            return supplies;
        }

        public int GetSupplyCount()
        {
            List<Supply> supplies = new List<Supply>();
            const string query = @"SELECT * FROM Supply";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    supplies.Add(SupplyDataAdapter(rdr));
                }
            }

            return supplies.Count();
        }

        public void UpdateSupplyById(Supply supply)
        {
            const string query = @"UPDATE Supply SET SupplyName = @supplyName, SupplyType = @supplyType, SupplyCost = @supplyCost WHERE SupplyId = @supplyId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@supplyName", supply.SupplyName);
                    cmd.Parameters.AddWithValue("@supplyType", supply.SupplyType);
                    cmd.Parameters.AddWithValue("@supplyCost", supply.SupplyCost);
                    cmd.Parameters.AddWithValue("@supplyId", supply.SupplyId);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

        }
        public void AddASupply(Supply supply)
        {
            const string query = @"INSERT Supply (SupplyName,SupplyType,SupplyCost)" +
                                 " VALUES(@supplyName, @supplyType, @supplyCost)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@supplyName", supply.SupplyName);
                    cmd.Parameters.AddWithValue("@supplyType", supply.SupplyType);
                    cmd.Parameters.AddWithValue("@supplyCost", supply.SupplyCost);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

        }


        public void DeleteSupplyById(int supplyId)
        {
            const string query = @"DELETE SUPPLY WHERE SupplyId = @supplyId";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@supplyId", supplyId);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

        }

        private Supply SupplyDataAdapter(SqlDataReader reader)
        {
            Supply supply = new Supply();

            supply.SupplyId = Convert.ToInt32(reader["SupplyId"]);
            supply.SupplyName = Convert.ToString(reader["SupplyName"]);
            supply.SupplyType = Convert.ToString(reader["SupplyType"]);
            supply.SupplyCost = Convert.ToDecimal(reader["SupplyCost"]);

            return supply;
        }
    }
}
