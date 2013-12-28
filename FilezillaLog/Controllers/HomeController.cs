﻿using FilezillaLog.Entities;
using FilezillaLog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilezillaLog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.baseUrl = Request.RawUrl;
            return View("index");
        }
    }
}