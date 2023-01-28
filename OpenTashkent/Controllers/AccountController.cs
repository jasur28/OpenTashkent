using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenTashkent.Data;
using OpenTashkent.Models;

namespace OpenTashkent.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly UserManager<ApplicationUser> _userManager;
        private readonly CustomDbContext _userDbContext;
        public AccountController(ILogger<HomeController> logger,
            CustomDbContext userDbContext)
        {
            _logger = logger;
            _userDbContext = userDbContext;
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SignIn(string login, string password)
        //{
        //    //var user = new ApplicationUser
        //    //{
        //    //    UserName = login,
        //    //    FirstName = "Maruf",
        //    //    LastName = "Maruf"
        //    //};
        //    //_userDbContext.Users.Add(user);
        //    //_userDbContext.SaveChanges();
        //    //return Ok();
        //    var users = _userDbContext.Users.Where(x => x.UserName == login);

        //    //var user = users.FirstOrDefault(x=>x == login);
        //    return Ok();
        //    //if (user != null)
        //    //{
        //    //    if (user.PasswordHash == password)
        //    //    {
        //    //        return Ok("Signed in");
        //    //    }
        //    //    return Ok("Not signed in");
        //    //}
        //    //return Ok("NOT SIGNED IN");
        //    return RedirectToAction("Index", "Home");
        //}
        //[HttpPost]
        //public IActionResult SignUp([FromBody]ApplicationUser applicationUser)
        //{
        //    _userDbContext.Add(applicationUser);
        //    _userDbContext.SaveChanges();
        //    return RedirectToAction("Index", "Home");
        //}

    }
}
