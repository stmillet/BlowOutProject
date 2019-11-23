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

        //Create the database object
        private InstrumentRentalContext db = new InstrumentRentalContext();
       
   
        // GET: Rentals
        public ActionResult Index()
        {
            return View(db.Instrument.ToList());
        }

        //After Instrument is chosen, takes user to add a client
        public ActionResult AddClient(int ID)
        {
            return View();
        }

        //Verifies the data is valid, and then adds the client to the database and updates 
        //instrument clientID then takes them to the final display page.
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


        //puts the data in viewbags so that it can be displayed on this page.
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