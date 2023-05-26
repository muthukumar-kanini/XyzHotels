using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using XyzHotels.models;


namespace XyzHotels.Repo
{
    public class HotelClass : IHotel
    {
        private readonly HotelContext _hotelContext;

        public HotelClass(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public IEnumerable<Hotel> GetHotel()
        {
            return _hotelContext.Hotels.Include(x => x.Rooms);
        }

        public Hotel GetHotelById(int hotelId)
        {
            return _hotelContext.Hotels.Include(x => x.Rooms).FirstOrDefault(h => h.HotelId == hotelId);
        }

        public Hotel PostHotel(Hotel hotel)
        {
            _hotelContext.Hotels.Add(hotel);
            _hotelContext.SaveChanges();
            return hotel;
        }

        public Hotel PutHotel(int hotelId, Hotel hotel)
        {
            var existingHotel = _hotelContext.Hotels.Find(hotelId);
            if (existingHotel != null)
            {
                _hotelContext.Entry(existingHotel).CurrentValues.SetValues(hotel);
                _hotelContext.SaveChanges();
            }
            return existingHotel ?? throw new Exception($"Hotel with ID {hotelId} not found."); ;
        }

        public Hotel DeleteHotel(int hotelId)
        {
            var existingHotel = _hotelContext.Hotels.Find(hotelId);
            if (existingHotel != null)
            {
                _hotelContext.Hotels.Remove(existingHotel);
                _hotelContext.SaveChanges();
            }
            return existingHotel ?? throw new Exception($"Hotel with ID {hotelId} not found.");
        }
    }
}
