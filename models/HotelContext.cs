using Microsoft.EntityFrameworkCore;

namespace XyzHotels.models
{
    public class HotelContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }

       

        public HotelContext(DbContextOptions<HotelContext> options):base(options) { }
    }
}
