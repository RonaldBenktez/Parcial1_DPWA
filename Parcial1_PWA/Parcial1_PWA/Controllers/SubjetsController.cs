using Microsoft.AspNetCore.Mvc;
using Parcial1_PWA.Models;
using System.Diagnostics;

namespace Parcial1_PWA.Controllers
{
    public class SubjetsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SubjetsController(ILogger<HomeController> logger)
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
