using System.ComponentModel.DataAnnotations;

namespace XyzHotels.models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string? RoomName { get; set; }
        public int RoomCount { get; set; }

        public string? RoomAvailability { get; set; }

        public int? RoomPrice { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
