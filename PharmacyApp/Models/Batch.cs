namespace PharmacyApp.Models
{
    public class Batch
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int Count { get; set; }
    }
}
