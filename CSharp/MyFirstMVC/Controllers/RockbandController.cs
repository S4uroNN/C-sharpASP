using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class RockbandController : Controller
    {
        public IActionResult RockBands()
        {

            List<String> bands = new List<String>();

            bands.Add("1");
            bands.Add("2");
            bands.Add("3");
            bands.Add("4");
            bands.Add("5");
            bands.Add("6");
            bands.Add("7");
            bands.Add("8");
            bands.Add("9");
            bands.Add("10");

            ViewBag.bands = bands;
            return View();
        }
    }
}
