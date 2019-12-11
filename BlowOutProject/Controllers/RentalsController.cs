using BlowOutProject.DAL;
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
        private InstrumentRentalContext db = new InstrumentRentalContext();

        //initialize values to instrument object
        public static List<Instrument> lstInstruments = new List<Instrument>()
        {/*
            new Instrument { InstDescription = "Trumpet", InstUsedPrice = 25, InstNewPrice = 55 },
            new Instrument { InstDescription = "Trombone", InstUsedPrice = 35, InstNewPrice = 60 },
            new Instrument { InstDescription = "Tuba", InstUsedPrice = 50, InstNewPrice = 70 },
            new Instrument { InstDescription = "Flute", InstUsedPrice = 25, InstNewPrice = 40 },
            new Instrument { InstDescription = "Clarinet", InstUsedPrice = 27, InstNewPrice = 35 },
            new Instrument { InstDescription = "Saxophone", InstUsedPrice = 30, InstNewPrice = 42 }
            */
        };
        
        // GET: Rentals
        public ActionResult Index()
        {
            return View(db.Instrument.ToList());
        }

        //pass instrument information to model when instrument is chosen
        public ActionResult Details(string name)
        {
            Instrument theInst = lstInstruments.Find(x => x.InstDescription == name);
            return View(theInst);
        }

        //pass new instrument information from model to view
        public ActionResult New(int instID)
        {
            Instrument myInstrument = db.Instrument.Find(instID);
            return View(myInstrument);
        }

        //pass used instrument information from model to view
        public ActionResult Used(string nameIn)
        {
            Instrument myInstrument = lstInstruments.FirstOrDefault(x => x.InstDescription == nameIn);
            return View(myInstrument);
        }

        //pass client information to view
        public ActionResult AddClient()
        {
            return View();
        }
    }
}