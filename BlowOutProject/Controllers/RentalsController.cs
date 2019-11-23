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

        //initialize values to instrument object
        private InstrumentRentalContext db = new InstrumentRentalContext();
        /*{
            new Instrument { InstDescription = "Trumpet", InstUsedPrice = 25, InstNewPrice = 55 },
            new Instrument { InstDescription = "Trombone", InstUsedPrice = 35, InstNewPrice = 60 },
            new Instrument { InstDescription = "Tuba", InstUsedPrice = 50, InstNewPrice = 70 },
            new Instrument { InstDescription = "Flute", InstUsedPrice = 25, InstNewPrice = 40 },
            new Instrument { InstDescription = "Clarinet", InstUsedPrice = 27, InstNewPrice = 35 },
            new Instrument { InstDescription = "Saxophone", InstUsedPrice = 30, InstNewPrice = 42 }
        };*/

        // GET: Rentals
        public ActionResult Index()
        {
            return View(db.Instrument.ToList());
        }

        //pass instrument information to model when instrument is chosen
        public ActionResult AddClient(int ID)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddClient([Bind(Include = "ClientID,ClientFirstName,ClientLastName,ClientAddress,ClientCity,ClientState,ClientZipCode,ClientEmail,ClientPhone")] Client client, int ID)
        {
            if (ModelState.IsValid)
            {
                db.Client.Add(client);
                db.SaveChanges();

                //Look up Instrument
                Instrument inst = db.Instrument.Find(ID);

                inst.ClientID = client.ClientID;
                db.SaveChanges();

                return RedirectToAction("Summary", new { ClientID = client.ClientID, InstrumentID = inst.InstrumentID });
            }

            return View(client);
        }


        //pass new instrument information from model to view
        public ActionResult Summary(int ClientID, int InstrumentID)
        {
            Client client = db.Client.Find(ClientID);
            Instrument inst = db.Instrument.Find(InstrumentID);

            ViewBag.Client = client;
            ViewBag.Inst = inst;
            ViewBag.After18 = inst.InstPrice * 18;
            return View();
        }
    }

}