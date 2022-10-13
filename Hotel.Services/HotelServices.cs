using Hotel.Model.Interfaces.Repositories;
using Hotel.Model.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public class HotelServices : IHotelServices
    {
        private readonly IHotelRepositories _hotelRepositories;
        private readonly ILogger _logger;

        public HotelServices(ILogger<HotelServices> logger, IHotelRepositories hotelRepositories)
        {
            _hotelRepositories = hotelRepositories;
            _logger = logger;
        }

        public async Task<IEnumerable<Hotel.Model.Models.Hotel>> GetHotels()
        {
            return await _hotelRepositories.GetHotels();
        }

        public async Task<Hotel.Model.Models.Hotel> GetHotel(int id)
        {
            return await _hotelRepositories.GetHotel(id);
        }

        public async Task<Model.Models.Hotel> AddHotel(Model.Models.Hotel hotel)
        {
            _logger.LogInformation("Add new hotel");
            return await _hotelRepositories.AddHotel(hotel);
        }

        public Model.Models.Hotel UpdateHotel(Model.Models.Hotel hotel)
        {
            return _hotelRepositories.UpdateHotel(hotel);
        }

        public async Task<int> DeleteHotel(int id)
        {
            return await _hotelRepositories.DeleteHotel(id);
        }
    }
}
