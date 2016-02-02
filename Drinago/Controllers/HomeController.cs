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
            ViewBag.Message = "Hello";
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
            ViewBag.Message3 = "Notice about registration";
            ViewBag.Message4 = "Team behind the project";
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
            ViewBag.Message1 = "Basic Info";
            ViewBag.Message2 = "Topographical position";
            ViewBag.Message3 = "Area of Gorazde";
            ViewBag.Message4 = "Ethnicity and Religion";
            ViewBag.Message5 = "Climate, electricity, water supply, currency";
            ViewBag.Message6 = "Population";
            ViewBag.Message7 = "Time zone";
            ViewBag.Message8 = "Holidays";
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

        public ActionResult WhatToDo()
        {
            ViewBag.Message = "Things to do";
            ViewBag.Message1 = "";
            ViewBag.Message2 = "";
            ViewBag.Message3 = "";
            ViewBag.Message4 = "";
            ViewBag.Message5 = "";
            ViewBag.Message6 = "";

            return View();
        }

        public ActionResult WhereToStay()
        {
            ViewBag.Message = "Where to Stay";
            ViewBag.Message1 = "Hotel Behar";
            ViewBag.Message2 = "Casablanca";
            ViewBag.Message3 = "";
            ViewBag.Message4 = "";
            ViewBag.Message5 = "";
            ViewBag.Message6 = "";

            return View();
        }

        public ActionResult WhereToShop()
        {
            ViewBag.Message = "Where to Shop";
            ViewBag.Message1 = "";
            ViewBag.Message2 = "";
            ViewBag.Message3 = "";
            ViewBag.Message4 = "";
            ViewBag.Message5 = "";
            ViewBag.Message6 = "";

            return View();
        }

        public ActionResult WhereToEat()
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

        public ActionResult WhatToSee()
        {
            ViewBag.Message = "What to See";
            ViewBag.Message1 = "";
            ViewBag.Message2 = "";
            ViewBag.Message3 = "";
            ViewBag.Message4 = "";
            ViewBag.Message5 = "";
            ViewBag.Message6 = "";

            return View();
        }

    }
}