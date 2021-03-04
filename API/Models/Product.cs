namespace API.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public string ProductImage { get; set; }
        public string OwnerId { get; set; }
    }
}