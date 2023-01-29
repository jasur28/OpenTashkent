using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenTashkent.Constraints;
using OpenTashkent.Data;
using OpenTashkent.Models;
using System.Diagnostics;

namespace OpenTashkent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //private readonly CustomDbContext _userDbContext;
        //public HomeController(ILogger<HomeController> logger,
        //    CustomDbContext userDbContext)
        //{
        //    _logger = logger;
        //    _userDbContext = userDbContext;
        //}

        //public IActionResult Index()
        //{
        //    ViewData["IsSignedIn"] = false;
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        ViewData["IsSignedIn"] = true;
        //        ViewData["Username"] = User.Identity.Name;
        //    }
        //    else
        //    {
        //        ViewData["IsSignedIn"] = false;
        //    }
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}