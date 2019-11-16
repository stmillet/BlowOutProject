using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOutProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //pass website about information to viewbag
        public ActionResult About()
        {
            ViewBag.Message = "We are BlowOut Instrument Rentals! Thank you for coming to our website.";

            return View();
        }

        //pass contact page string to viewbag
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}