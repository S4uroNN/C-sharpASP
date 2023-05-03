using Lektion15.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lektion15.Controllers
{
    public class PersonController : Controller
    {
        
        public IActionResult Index()
        {
            Person p = new Person("Ole","Hansen",95);
           
            return View("index",p);
        }

        
        public IActionResult Find(string firstname, string lastname,int id)
        {
            return View();
        }
    }
}
