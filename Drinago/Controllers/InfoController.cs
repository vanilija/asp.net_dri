using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drinago.Controllers
{
    public class InfoController : Controller
    {
        public ActionResult Info()
        {
            return View("~/Views/Info/Information.cshtml");
        }

        public ActionResult Geology()
        {
            return View("~/Views/Info/Geology.cshtml");
        }

        public ActionResult Archeology()
        {
            return View("~/Views/Info/Archeology.cshtml");
        }

        public ActionResult History()
        {
            return View("~/Views/Info/History.cshtml");
        }

        public ActionResult Geography()
        {
            return View("~/Views/Info/Geography.cshtml");
        }
    }
}