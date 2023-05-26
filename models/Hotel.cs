using System.ComponentModel.DataAnnotations;

namespace XyzHotels.models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? HotelDescription { get; set; }
        public string? HotelLocation { get; set; }

        public int? HotelPhoneNumber { get; set; }  
        public ICollection<Room>? Rooms { get; set; }
        
    }
}
