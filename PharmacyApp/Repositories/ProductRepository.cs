using PharmacyApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyApp.Repositories
{
    public class ProductRepository : BaseRepository
    {
        private const string _productAdd = "Product_Add";
        private const string _productDelete = "Product_Delete";
        private const string _productsGet = "Products_GetByPharmacy";

        public int AddProduct(Product product)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_productAdd, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Name", product.Name);

            sqlConnection.Open();
            return sqlCommand.ExecuteNonQuery();
        }

        public void DeleteProduct(int id)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_productDelete, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
        }

        public List<ProductOutput> GetProductsByPharmacy(int id)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_productsGet, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            List<ProductOutput> result = new();

            while (sqlReader.HasRows && sqlReader.Read())
            {
                result.Add(new ProductOutput(sqlReader.GetString(0), sqlReader.GetInt32(1)));
            }

            return result; 
        }
    }
}
