using PharmacyApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyApp.Repositories
{
    public class StoreRepository : BaseRepository
    {
        private const string _storeAdd = "Store_Add";
        private const string _storeDelete = "Store_Delete";

        public int AddStore(Store store)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_storeAdd, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Name", store.Name);
            sqlCommand.Parameters.AddWithValue("@PharmacyId", store.PharmacyId);

            sqlConnection.Open();
            return sqlCommand.ExecuteNonQuery();
        }

        public void DeleteStore(int id)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_storeDelete, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
        }
    }
}
