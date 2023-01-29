using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenTashkent.Constraints;
using OpenTashkent.Data;
using OpenTashkent.Models;

namespace OpenTashkent.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly UserDbContext userDbContext;
        //private readonly CustomDbContext _userDbContext;
        public AccountController(ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager,
            UserDbContext userDbContex)
        {
            _logger = logger;
            //_userDbContext = userDbContext;
            _userManager = userManager;
            userDbContex = userDbContex;
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
            //var user = new ApplicationUser
            //{
            //    FirstName = "MAruf",
            //    LastName = "Ravshanov",
            //    Email = "abcd",
            //    Adress = "asdb",
            //    UserName = "asdb",
            //    EmailConfirmed = false,
            //    LockoutEnabled = false,
            //    AccessFailedCount = 0,
            //    Diseases = new[] { new Disease { DiseaseName = "NOT WALKABLE" } },
            //    SubjectsCanTeach = new[] {new Subject { SubjectName = "Physics"} },

            //};
            //var user = new IdentityUser
            //{
            //    Email = "asdnas",
            //    UserName = "asdb"
            //};
            //userDbContext.Add(user);
            //userDbContext.SaveChanges();
            //var users = _userManager.Users;
            //int j = 10;
            //return View();
        }
        //[HttpPost]
        //public IActionResult SignIn(string login, string password)
        //{
        //    var student = _userDbContext.Students.FirstOrDefault(x => x.UserName == login);
        //    var teacher = _userDbContext.Teachers.FirstOrDefault(x => x.UserName == login);
        //    if (student != null) 
        //    {
        //        if (student.Password == password)
        //        {
        //            Authenticated.isAuthorized = true;
        //            object toPass = student.UserName;
        //            return RedirectToAction("Index", "Teacher", new { Name = student.UserName });
        //        }
        //        return Ok("NOT SUCCESS");
        //    }
        //    if (teacher != null)
        //    {
        //        if (teacher.Password == password)
        //        {
        //            Authenticated.isAuthorized = true;
        //            object toPass = student.UserName;
        //            return RedirectToAction("Index", "Teacher", new {Name =student.UserName});
        //        }
        //        return Ok("NOT SUCCESs");
        //    }
        //    return Ok("NOT SUCCESs");
        //    //return RedirectToAction("Index", "Home");
        //}
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
