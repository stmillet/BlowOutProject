using BlowOutProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOutProject.Controllers
{
    public class RentalsController : Controller
    {

        public static List<Instrument> lstInstruments = new List<Instrument>()
        {
            new Instrument { Name = "Trumpet", PriceUsed = "$55 a month", PriceNew = "$25 a month" }
        };
        
        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }

}