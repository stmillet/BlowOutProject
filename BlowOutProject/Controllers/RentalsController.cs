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
            new Instrument { Name = "Trumpet", PriceUsed = "$25 a month", PriceNew = "$55 a month" },
            new Instrument { Name = "Trombone", PriceUsed = "$35 a month", PriceNew = "$60 a month" },
            new Instrument { Name = "Tuba", PriceUsed = "$50 a month", PriceNew = "$70 a month" },
            new Instrument { Name = "Flute", PriceUsed = "$25 a month", PriceNew = "$40 a month" },
            new Instrument { Name = "Clarinet", PriceUsed = "$27 a month", PriceNew = "$35 a month" },
            new Instrument { Name = "Saxophone", PriceUsed = "$30 a month", PriceNew = "$42 a month" }
        };
        
        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string name)
        {
            Instrument theInst = lstInstruments.Find(x => x.Name == name);
            return View(theInst);
        }
    }

}