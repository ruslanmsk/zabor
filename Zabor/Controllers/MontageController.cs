﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zabor.Controllers
{
    public class MontageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}