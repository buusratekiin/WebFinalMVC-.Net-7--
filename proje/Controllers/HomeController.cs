using Microsoft.AspNetCore.Mvc;
using proje.Models;

using Service.Models;
using System.Diagnostics;

namespace proje.Controllers
{
    public class HomeController : Base
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            return View();
        }

        public IActionResult Privacy()

        {
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    } 
}
