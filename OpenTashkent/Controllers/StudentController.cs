using Microsoft.AspNetCore.Mvc;

namespace OpenTashkent.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Empty()
        {
            return View();
        }
    }
}
