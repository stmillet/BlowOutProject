using BlowOutProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//this is emmett's test comment
namespace BlowOutProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        private InstrumentRentalContext db = new InstrumentRentalContext();
        
        public ActionResult About()
        {
            ViewBag.Message = "We are BlowOut Instrument Rentals! Thank you for coming to our website.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}