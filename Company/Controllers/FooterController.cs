using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.BusinessLayer.Concrete;
using Company.DataAccessLayer.Concrete;
using Company.Models;

namespace Company.Controllers
{
    public class FooterController : Controller
    {
        Context db = new Context();
        CompanyInfo cı = new CompanyInfo();
        CompanySocialMediaManager csm = new CompanySocialMediaManager();
        // GET: Footer
        public ActionResult Index()
        {
            cı.footer = db.Footer.FirstOrDefault();
            cı.companySocialMedia = csm.GetList();
            return View(cı);
        }
    }
}