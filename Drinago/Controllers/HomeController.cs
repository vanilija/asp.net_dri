using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drinago.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Transportation()
        {
            return View();
        }

        public ActionResult WhereTo()
        {
            return View();
        }

        public ActionResult FoodAndDrink()
        {
            return View();
        }
  
        public ActionResult Geology()
        {
            return View();
        }

        public ActionResult Archeology()
        { 
            return View();
        }

        public ActionResult Geography()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View("~/Views/Home/Feedback.aspx");
        }
    }
}