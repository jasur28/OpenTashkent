using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            var students = _userDbContext.Students;
            
            return View(students);
        }
    }
}
