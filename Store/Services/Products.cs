using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Store.Services
{
    public class Products
    {
        private string? connectionString;

        public Products()
        {
            if (Program.Configuration != null)
            {
                connectionString = Program.Configuration.GetConnectionString("default");
            }
        }

        public void InsertProduct(string productName, string price)
        {
            if (connectionString == null) { return; }

            decimal priceDecimal = decimal.Parse(price,CultureInfo.InvariantCulture);
            int id;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "InsertProduct";
                    cmd.Connection = sqlConnection;

                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@price", priceDecimal);

                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Id"].Direction = System.Data.ParameterDirection.Output;

                    sqlConnection.Open();

                    cmd.ExecuteNonQuery();

                    id = Convert.ToInt32(cmd.Parameters["@Id"].Value);
                }
            }
        }
    }
}
