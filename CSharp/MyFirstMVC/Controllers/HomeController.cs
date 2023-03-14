using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
