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
            new Instrument { InstDescription = "Trumpet", InstUsedPrice = 25 , InstNewPrice = 55 },
            new Instrument { InstDescription = "Trombone", InstUsedPrice = 35, InstNewPrice = 60 },
            new Instrument { InstDescription = "Tuba", InstUsedPrice = 50, InstNewPrice = 70 },
            new Instrument { InstDescription = "Flute", InstUsedPrice = 25, InstNewPrice = 40 },
            new Instrument { InstDescription = "Clarinet", InstUsedPrice = 27, InstNewPrice = 35 },
            new Instrument { InstDescription = "Saxophone", InstUsedPrice = 30, InstNewPrice = 42 }
        };
        
        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string name)
        {
            Instrument theInst = lstInstruments.Find(x => x.InstDescription == name);
            return View(theInst);
        }

    
        public ActionResult New(string nameIn)
        {
            //FIXME
            Instrument myInstrument = lstInstruments.Find(x => x.InstDescription == nameIn);
            return View(myInstrument);
        }

        public ActionResult Used(string nameIn)
        {
            Instrument myInstrument = lstInstruments.FirstOrDefault(x => x.InstDescription == nameIn);
            return View(myInstrument);
        }
    }

}