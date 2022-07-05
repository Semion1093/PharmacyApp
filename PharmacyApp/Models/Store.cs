namespace PharmacyApp.Models
{
    public class Store
    {
        public int Id { get; set; }
        public int PharmacyId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
