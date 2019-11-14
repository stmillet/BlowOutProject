using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOutProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            string EmailString = "Thanks " + name + "We will send an email to " + email;
            ViewBag.EmailConfirmation = EmailString;
            return View();
        }
    }
}