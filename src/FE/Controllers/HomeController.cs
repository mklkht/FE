using System.Collections.Generic;
using FE.Models;
using Microsoft.AspNetCore.Mvc;

namespace FE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Custom()
        {
            ViewData["Message"] = "Your custom page.";
            var list = new List<Student> {new Student {Id = 1, Name = "FN1"}, new Student {Id = 2, Name = "FN2"}};
            return View(list);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}