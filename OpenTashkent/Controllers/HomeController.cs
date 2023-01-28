using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenTashkent.Data;
using OpenTashkent.Models;
using System.Diagnostics;

namespace OpenTashkent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomDbContext _userDbContext;
        public HomeController(ILogger<HomeController> logger,
            CustomDbContext userDbContext)
        {
            _logger = logger;
            _userDbContext = userDbContext;
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