﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Corwords.Controllers
{
    public class HomeController : Controller
    {
        public IConfigurationRoot Configuration { get; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
