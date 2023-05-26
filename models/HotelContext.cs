using Microsoft.EntityFrameworkCore;

namespace XyzHotels.models
{
    public class HotelContext:DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<User>Users { get; set; }


       

        public HotelContext(DbContextOptions<HotelContext> options):base(options) { }
    }
}
