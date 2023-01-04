using FarkWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FarkWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Fark fark)
        {
            var number1_ = fark.BirinciSayi;
            var number2_ = fark.İkinciSayi;
            var islem = (number1_ - number2_);
            var message = string.Empty;
            message = "Fark : " + islem;
            ViewBag.Message = message;
            return View("fark");
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