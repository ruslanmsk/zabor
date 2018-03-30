using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zabor.Controllers
{
    public class FencesController : Controller
    {
        public IActionResult Cement()
        {
            return View();
        }

        public IActionResult SheetMetal()
        {
            return View();
        }

        public IActionResult Slave()
        {
            return View();
        }
    }
}