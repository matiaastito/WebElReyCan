﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebElReyCan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "Bienvenido";
            ViewBag.Fecha= DateTime.Now.ToString();
            return View();
        }
    }
}