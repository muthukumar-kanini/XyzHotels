using System.ComponentModel.DataAnnotations;

namespace XyzHotels.models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; } = string.Empty;
        public string? CustomerEmail { get; set; }
        public string? CustomerPassword { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
