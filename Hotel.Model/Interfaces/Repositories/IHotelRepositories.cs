using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.Interfaces.Repositories
{
    public interface IHotelRepositories
    {
        Task<IEnumerable<Models.Hotel>> GetHotels();
        Task<Hotel.Model.Models.Hotel> GetHotel(int id);
        Task<Hotel.Model.Models.Hotel> AddHotel(Hotel.Model.Models.Hotel hotel);
        Hotel.Model.Models.Hotel UpdateHotel(Hotel.Model.Models.Hotel hotel);
        Task<int> DeleteHotel(int id);
    }
}
