using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int alder =0;
            string navn = "matrhias";

            ViewBag.alder = alder;
            ViewBag.navn = navn;
            return View();
        }
    }
}
