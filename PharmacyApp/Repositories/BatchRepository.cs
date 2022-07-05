using PharmacyApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyApp.Repositories
{
    public class BatchRepository : BaseRepository
    {
        private const string _batchAdd = "Batch_Add";
        private const string _batchDelete = "Batch_Delete";

        public int AddBatch(Batch batch)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_batchAdd, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ProductId", batch.ProductId);
            sqlCommand.Parameters.AddWithValue("@StoreId", batch.StoreId);
            sqlCommand.Parameters.AddWithValue("@Count", batch.Count);

            sqlConnection.Open();
            return Convert.ToInt32(sqlCommand.ExecuteScalar());
        }

        public void DeleteBatch(int id)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_batchDelete, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
        }
    }
}
