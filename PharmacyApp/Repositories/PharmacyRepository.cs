using PharmacyApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyApp.Repositories
{
    public class PharmacyRepository : BaseRepository
    {
        private const string _pharmacyAdd = "Pharmacy_Add";
        private const string _pharmacyDelete = "Pharmacy_Delete";

        public int AddPharmacy(Pharmacy pharmacy)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_pharmacyAdd, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Name", pharmacy.Name);
            sqlCommand.Parameters.AddWithValue("@Adress", pharmacy.Adress); 
            sqlCommand.Parameters.AddWithValue("@Phone", pharmacy.Phone);

            sqlConnection.Open();
            return Convert.ToInt32(sqlCommand.ExecuteScalar());
        }

        public void DeletePharmacy(int id)
        {
            using var sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new(_pharmacyDelete, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
        }
    }
}
