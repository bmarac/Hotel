using Hotel.Model.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelServices _hotelServices;
        public HotelController(IHotelServices hotelServices)
        {
            _hotelServices = hotelServices;
        }

        /// <summary>
        /// Get all hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetHotels()
        {
            return Ok(await _hotelServices.GetHotels());
        }

        /// <summary>
        /// Get hotel by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetHotel(int id)
        {
            return Ok(await _hotelServices.GetHotel(id));
        }

        /// <summary>
        /// Add new hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> AddHotel(Model.Models.Hotel hotel)
        {
            return Ok(await _hotelServices.AddHotel(hotel));
        }

        /// <summary>
        /// Update hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateHotel(Model.Models.Hotel hotel)
        {
            return Ok(_hotelServices.UpdateHotel(hotel));
        }

        /// <summary>
        /// Delete hotel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult DeleteHotel(int id)
        {
            return Ok(_hotelServices.DeleteHotel(id));
        }
    }
}
