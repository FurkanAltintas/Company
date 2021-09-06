using Company.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class SliderController : Controller
    {
        SliderManager slider = new SliderManager();
        // GET: Slider
        public ActionResult Index()
        {
            var sliderList = slider.GetList();
            return View(sliderList);
        }
    }
}