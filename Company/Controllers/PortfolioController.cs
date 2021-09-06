using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.BusinessLayer.Concrete;
using Company.EntityLayer.Concrete;
using Company.Models;

namespace Company.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioType pt = new PortfolioType();
        PortfolioManager pm = new PortfolioManager();
        PortfolioCategoryManager pcm = new PortfolioCategoryManager();
        // GET: Portfolio
        public ActionResult Index()
        {
            pt.Portfolio = pm.GetList();
            pt.PortfolioCategory = pcm.GetList();
            return View(pt);
        }
    }
}