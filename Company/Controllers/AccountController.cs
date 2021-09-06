using Company.DataAccessLayer.Concrete;
using Company.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Company.Controllers
{
    public class AccountController : Controller
    {
        Context db = new Context();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            var log = db.Employee.Where(x => x.Email == employee.Email && x.Password == employee.Password && x.IsActive == true).FirstOrDefault();

            if (log != null)
            {
                FormsAuthentication.SetAuthCookie(log.Email, false);
                TempData["Email"] = log.Email;
                TempData["Profile"] = log.Image;
                Session["Id"] = log.Id;
                return RedirectToAction("Home", "Dashboard");
            }
            else
            {
                ViewBag.Error = "Email or password is incorrect";
                return View(employee);
            }
        }
    }
}