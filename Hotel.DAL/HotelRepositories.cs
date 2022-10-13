using Hotel.Model.Interfaces.Repositories;
using Hotel.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class HotelRepositories : IHotelRepositories
    {
        private readonly HotelDBContext _context;
        public HotelRepositories(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Hotel.Model.Models.Hotel>> GetHotels()
        {
            List<Hotel.Model.Models.Hotel> hotels = await _context.Hotels.ToListAsync();
            return hotels;
        }

        public async Task<Hotel.Model.Models.Hotel> GetHotel(int id)
        {
            return await _context.Hotels.Where(x => x.Id == id).FirstAsync();
        }

        public async Task<Hotel.Model.Models.Hotel> AddHotel(Hotel.Model.Models.Hotel hotel)
        {
            await _context.AddAsync(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public Hotel.Model.Models.Hotel UpdateHotel(Hotel.Model.Models.Hotel hotel)
        {
            _context.Update(hotel);
            _context.SaveChanges();
            return hotel;
        }

        public async Task<int> DeleteHotel(int id)
        {
            Hotel.Model.Models.Hotel hotel = await _context.Hotels.Where(x => x.Id == id).FirstAsync();
            if (hotel != null)
                _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
            return id;
        }
    }
}
