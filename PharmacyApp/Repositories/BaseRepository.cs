using System.Data.SqlClient;

namespace PharmacyApp.Repositories
{
    public class BaseRepository
    {
        protected static readonly string connectionString = "Server=SIMO\\SQLEXPRESS;Database=Pharmacy.DB;Trusted_Connection=True";
    }
}
