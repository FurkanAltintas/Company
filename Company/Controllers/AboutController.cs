using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.BusinessLayer.Concrete;

namespace Company.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager about = new AboutManager();
        // GET: About
        public ActionResult Index()
        {
            var aboutList = about.GetList();
            return View(aboutList);
        }
    }
}