﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VMR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Browse()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Sell()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}