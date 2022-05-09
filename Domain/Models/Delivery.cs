namespace Domain.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public Address From { get; set; }
        public Address To { get; set; }
        public List<Product> Products { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime DeliverDate { get; set; }
    }
}
