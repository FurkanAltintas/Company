using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.BusinessLayer.Concrete;
using Company.DataAccessLayer.Concrete;
using Company.EntityLayer.Concrete;
using Company.Models;

namespace Company.Controllers
{
    public class ContactController : Controller
    {
        ContactUs c = new ContactUs();
        private Context db = new Context();
        private ContactManager cm = new ContactManager();
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            c.footer = db.Footer.FirstOrDefault();
            return View(c);
        }

        [HttpPost]
        public ActionResult Index(ContactUs p)
        {
            var key = p.contact;
            key.CreDate = DateTime.Now;
            key.IsActive = true;
            cm.Add(key);
            return RedirectToAction("Index","Home");
        }
    }
}