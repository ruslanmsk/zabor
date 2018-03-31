using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zabor.Models;

namespace Zabor.Controllers
{
    //https://blackrockdigital.github.io/startbootstrap-scrolling-nav/
    //https://blackrockdigital.github.io/startbootstrap-one-page-wonder/
    //https://blackrockdigital.github.io/startbootstrap-landing-page/
    //http://demo.fuviz.com/reen/v1-7/one-page1.html
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
