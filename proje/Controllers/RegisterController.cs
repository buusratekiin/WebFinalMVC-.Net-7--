using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Service.Classes;
using Service.ViewModels;
using Service.Models;


namespace proje.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Hoşgeldiniz";
            return View();
        }

        [HttpPost]

        public IActionResult Index(RegisterVM vm)
        {
            ViewBag.Title = "Welcome";
            Authentication cslAuth = new Authentication();


            if (cslAuth.UsernamePasswordControl(vm.Email, vm.Paswordd))
            {
                ViewBag.Mesaj = "giriş başarılı TEBRİKLER";
                HttpContext.Session.SetString("UserSession", "1");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mesaj = cslAuth.ErrorMessage;
            }
            return View();

        }
    }
}


