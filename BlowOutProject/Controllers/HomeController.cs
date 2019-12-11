using BlowOutProject.DAL;
using BlowOutProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOutProject.Controllers
{
    public class HomeController : Controller
    {
        private InstrumentRentalContext db = new InstrumentRentalContext();

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

        [HttpGet]
        public ActionResult Create(int ID)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientID, ClientFirstName, ClientLastName, ClientAddress, ClientCity, ClientState, ClientZip")] Client client, int ID)
        {
            if(ModelState.IsValid)
            {
                db.Client.Add(client);
                db.SaveChanges();

                Instrument instrument = db.Instrument.Find(ID);

                instrument.ClientID = client.ClientID; 
                //db.Entry(instrument).State = EntityState.Modified;
                db.SaveChanges();
 
                return RedirectToAction("Summary", new { ClientID = client.ClientID, InstrumentID = instrument.InstrumentID });
            }
            return View(client);
        }
        
         public ActionResult Summary(int ClientID, int InstrumentID)
         {
            Client client = db.Client.Find(ClientID);
            Instrument instrument = db.Instrument.Find(InstrumentID);
            
            ViewBag.Client = client;
            ViewBag.Instrument = instrument;
            
            return View();
         }
    }
}