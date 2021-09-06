using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.BusinessLayer.Concrete;

namespace Company.Controllers
{
    public class ServicesController : Controller
    {
        private ServicesManager services = new ServicesManager();
        // GET: Services
        public ActionResult Index()
        {
            var servicesList = services.GetList();
            return View(servicesList);
        }
    }
}