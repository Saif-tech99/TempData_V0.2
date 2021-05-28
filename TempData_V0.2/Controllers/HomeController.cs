using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempData_V0._2.Models;

namespace TempData_V0._2.Controllers
{
    public class HomeController : Controller
    {
        // Get-Index
        public IActionResult Index()
        {
            TempData["Counter"] = 1;

            return View();
        }

        // Post-Index
        [HttpPost]
        public IActionResult Index(string click)
        {
            int x = (int)TempData.Peek("Counter");

            if (click == "Add")
            {
                x++;
            }
            else 
            {
                if (x > 0)
                {
                    x--;
                }
                else
                {
                    ViewBag.Message = "The value can not be negative";
                }
            }

            TempData["Counter"] = x;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
