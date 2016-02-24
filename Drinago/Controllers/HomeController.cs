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

        public ActionResult Notice()
        {
            return View("~/Views/Home/Notice.cshtml");
        }
}
}