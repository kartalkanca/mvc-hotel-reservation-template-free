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
                // Kullanıcı kaydını işleme al (veritabanına kaydet vb.)
                return RedirectToAction("Index", "Home"); // Örnek: ana sayfaya yönlendirme
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
                // Giriş yapma işlemi (kimlik doğrulama vb.)
                return RedirectToAction("Dashboard", "Home"); // Örnek: bir kullanıcı paneline yönlendirme
            }

            return View(model);
        }
    }
}
