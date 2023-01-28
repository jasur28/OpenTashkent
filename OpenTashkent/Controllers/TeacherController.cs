using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenTashkent.Constraints;
using OpenTashkent.Data;
using OpenTashkent.Models;
using OpenTashkent.Models.ViewModels;

namespace OpenTashkent.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomDbContext _userDbContext;
        public TeacherController(ILogger<HomeController> logger,
            CustomDbContext userDbContext)
        {
            _logger = logger;
            _userDbContext = userDbContext;
        }
        public IActionResult Index(string name)
        {
            if (Authenticated.isAuthorized)
            {
                ViewData["IsSignedIn"] = true;
                var abc = true.ToString();
                ViewData["Username"] = name;
            }
            if (User.Identity.IsAuthenticated)
            {
                ViewData["IsSignedIn"] = true;
                ViewData["Username"] = name;
            }
            else
            {
                ViewData["IsSignedIn"] = false;
            }

            var students = _userDbContext.Students.Include(x=>x.Diseases)
                .Include(x=>x.SubjectsInterestedIn);
            
            return View(students);
        }
        //public IActionResult Index(Teacher teacher)
        //{
        //    if (Authenticated.isAuthorized)
        //    {
        //        ViewData["IsSignedIn"] = true;
        //        ViewData["Username"] = teacher.UserName;
        //    }
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        ViewData["IsSignedIn"] = true;
        //        ViewData["Username"] = teacher.UserName;
        //    }
        //    else
        //    {
        //        ViewData["IsSignedIn"] = false;
        //    }

        //    var students = _userDbContext.Students.Include(x => x.Diseases)
        //        .Include(x => x.SubjectsInterestedIn);

        //    return View(students);
        //}

        public IActionResult ChooseTime()
        {
            return View();
        }
    }
}
