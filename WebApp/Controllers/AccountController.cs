using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        // Register GET
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        // Register POST
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullan�c� kayd�n� i�leme al (veritaban�na kaydet vb.)
                return RedirectToAction("Index", "Home"); // �rnek: ana sayfaya y�nlendirme
            }

            return View(model);
        }

        // Login GET
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        // Login POST
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Giri� yapma i�lemi (kimlik do�rulama vb.)
                return RedirectToAction("Dashboard", "Home"); // �rnek: bir kullan�c� paneline y�nlendirme
            }

            return View(model);
        }
    }
}