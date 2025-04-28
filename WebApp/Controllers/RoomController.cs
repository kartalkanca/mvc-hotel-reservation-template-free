using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly HotelBookingContext _context;

        public RoomController(HotelBookingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Logic to fetch rooms from context and pass to view
            return View();
        }
    }
}