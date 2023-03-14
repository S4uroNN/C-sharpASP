using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class TimeCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculator(IFormCollection formcollection)
        {

            int hours = Int32.Parse(formcollection["Hours"]);
            int minutes = Int32.Parse(formcollection["Minutes"]);
            int seconds = Int32.Parse(formcollection["Seconds"]);

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;


            ViewBag.Hours = hours;
            ViewBag.Minutes = minutes;
            ViewBag.Seconds = seconds;
            ViewBag.Total = total;
            return View("TimeCalculator");
        }
    }
}
