using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // Ana sayfa
        public IActionResult Index()
        {
            Console.WriteLine("Index aksiyonu �al��t�!");
            return View();
        }

        // Gizlilik sayfas�
        public IActionResult Privacy()
        {
            return View();
        }
    }
}