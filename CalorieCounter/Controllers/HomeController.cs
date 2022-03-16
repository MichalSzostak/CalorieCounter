using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalorieCounter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HowTo()
        {
           return View();
        }

        public ActionResult UnderstandingCalories()
        {
            return View();
        }

        public ActionResult Podcasts()
        {
            return View();
        }
    }
}