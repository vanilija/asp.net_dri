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
            ViewBag.Message = "Basic Info";
            ViewBag.Message2 = "Topographical position";
            ViewBag.Message3 = "Area of Gorazde";
            ViewBag.Message4 = "Ethnicity and Religion";
            ViewBag.Message5 = "Climate, electricity, water supply, currency";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Editors Notice";
            ViewBag.Message2 = "Our Vision";
            ViewBag.Message3 = "Team behind the project";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Info()
        {
            ViewBag.Message = "Additional Information";
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
            ViewBag.Message = "Food and Drink";
            ViewBag.Message1 = "Hotel Behar";
            ViewBag.Message2 = "Casablanca";
            ViewBag.Message3 = "Monza 2";
            ViewBag.Message4 = "Zute Dunje";
            ViewBag.Message5 = "Ciro";
            ViewBag.Message6 = "";

            return View();
        }

    }
}