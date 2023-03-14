using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Diagnostics;

namespace MyFirstMVC.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult SimpleCalc()
        {
         


            return View();
        }
        [HttpPost]
        public IActionResult SimpleCalc(IFormCollection formcolleciton)
        {
            double firstnumber = double.Parse(formcolleciton["FirstNumber"]);
            double secondnumber = double.Parse(formcolleciton["SecondNumber"]);
            double total;


            string operators = formcolleciton["operator"];

            switch (operators)
            {
                case "+":
                    total = firstnumber + secondnumber;
                    ViewBag.Total = total;
                    break;
                case "-":
                    total = firstnumber - secondnumber;
                    ViewBag.Total = total;
                    break;
                case "*":
                    total = firstnumber * secondnumber;
                    ViewBag.Total = total;
                    break;
                case "/":
                    total = firstnumber / secondnumber;
                    ViewBag.Total = total;
                    break;
            }
            return View();
        }
    }
}
