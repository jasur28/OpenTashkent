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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly UserDbContext _userDbContext;
        public HomeController(ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager,
            UserDbContext userDbContext)
        {
            _logger = logger;
            _userManager = userManager;
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