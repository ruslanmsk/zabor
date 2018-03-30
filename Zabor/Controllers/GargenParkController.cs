using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zabor.Controllers
{
    public class GargenParkController : Controller
    {
        public IActionResult Tables()
        {
            return View();
        }

        public IActionResult Chairs()
        {
            return View();
        }

        public IActionResult Benches()
        {
            return View();
        }

        public IActionResult Chargrills()
        {
            return View();
        }

        public IActionResult Visors()
        {
            return View();
        }

        public IActionResult Canopies()
        {
            return View();
        }
    }
}