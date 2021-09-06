using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.BusinessLayer.Concrete;
using Company.Models;

namespace Company.Controllers
{
    public class TeamController : Controller
    {
        EmployeeManager employee = new EmployeeManager();
        EmployeeSocialMediaManager esm = new EmployeeSocialMediaManager();
        EmployeeSocial es = new EmployeeSocial();
        // GET: Team
        public ActionResult Index()
        {
            es.Employee = employee.GetList().Where(x => x.AuthorityId == 2).ToList();
            es.EmployeeSocialMedia = esm.GetList();
            return View(es);
        }
    }
}