﻿using Microsoft.AspNetCore.Mvc;

namespace Util.Samples.Webs.Controllers {
    public class HomeController : Controller
    {
        public HomeController() {
        }


        public IActionResult Index() {
            return View();
        }
    }
}
