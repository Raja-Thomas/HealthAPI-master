using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClientApp.Models;
namespace ClientApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Employees());
        }
        public IActionResult CreateorUpdate(Employees model)
        {
            ModelState.Clear();
            return PartialView("_employeepartial", model);
        }
    }
}