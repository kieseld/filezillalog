using FilezillaLog.Entities;
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
        [Authorize(Users = "Administrator")]
        public ActionResult Index()
        {
            string baseUrl = Request.RawUrl;
            if (!baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl + "/";
            }
            ViewBag.baseUrl = baseUrl;
            return View("index");
        }
    }
}
