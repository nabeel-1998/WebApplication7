using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            ViewData["Result"] = "0";
            return View();
        }
        [HttpPost]
        public ActionResult Index(decimal tb1, decimal tb2)
        {
            decimal res = tb1 + tb2;
            ViewData["Result"] = res;
            return View();
        }
        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Models.Maths maths)
        {
            decimal frst = maths.firstnum;
            decimal sec = maths.secondnum;
            decimal final = frst + sec;
            ViewData["Answer"] = final;
            return View();
        }
        public ActionResult StudentData()
        {
            return View();
        }
    }
}