using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalorieCounter.Controllers
{
    public class FoodManagerController : Controller
    {
        // GET: FoodManager
        public ActionResult Index()
        {
            return View();
        }
    }
}