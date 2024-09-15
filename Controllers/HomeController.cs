using Microsoft.AspNetCore.Mvc;

namespace mvc33.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
