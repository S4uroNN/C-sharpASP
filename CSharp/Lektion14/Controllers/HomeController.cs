using Lektion14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Text.Json;

namespace Lektion14.Controllers
{
    public class HomeController : Controller
    {
        List<SelectListItem> countrieslist = new List<SelectListItem>();

        [HttpGet]
        public IActionResult Index(string Countries)
        {
            if (HttpContext.Session.GetString("countrieslist") == null)
            {
                countrieslist.Add(new SelectListItem { Text = "China", Value = "CN" });
                countrieslist.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
                countrieslist.Add(new SelectListItem { Text = "Romania", Value = "RO" });
                countrieslist.Add(new SelectListItem { Text = "Spain", Value = "SP" });
                countrieslist.Add(new SelectListItem { Text = "Sweden", Value = "SW" });

                string json = JsonSerializer.Serialize(countrieslist);
                HttpContext.Session.SetString("countrieslist", json);
            }
            else
            {
                string json = HttpContext.Session.GetString("countrieslist");
                countrieslist = JsonSerializer.Deserialize<List<SelectListItem>>(json);



            }

            ViewBag.Countries = countrieslist;

            ViewBag.Countrycode = Countries;

            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {

            string country = form["Country"];
            string value = form["Value"];

            string json = HttpContext.Session.GetString("countrieslist");
            countrieslist = JsonSerializer.Deserialize<List<SelectListItem>>(json);

            countrieslist.Add(new SelectListItem { Text = country, Value = value });

            json = JsonSerializer.Serialize(countrieslist);
            HttpContext.Session.SetString("countrieslist", json);

            ViewBag.Countries = countrieslist;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}