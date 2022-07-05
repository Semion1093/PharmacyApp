namespace PharmacyApp.Models
{
    public class ProductOutput
    {
        public ProductOutput(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public string Name { get; set; }
        public int Count { get; set; }
    }
}
