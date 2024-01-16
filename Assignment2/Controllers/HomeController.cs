using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Mushroom Families";
            return View();
        }

        public ActionResult Mushroom()
        {
            ViewBag.Title = "Mushroom Details";
            return View();
        }

        public ActionResult RecordMushroom()
        {
            ViewBag.Title = "Record Mushroom";
            return View();
        }

        public ActionResult Modify()
        {
            ViewBag.Title = "Modify the Details";
            return View();
        }
    }
}