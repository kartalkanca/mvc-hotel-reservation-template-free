using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // Ana sayfa
        public IActionResult Index()
        {
            Console.WriteLine("Index aksiyonu çalýþtý!");
            return View();
        }

        // Gizlilik sayfasý
        public IActionResult Privacy()
        {
            return View();
        }
    }
}