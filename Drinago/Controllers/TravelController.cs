using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drinago.Controllers
{
    public class TravelController : Controller
    {
        // GET: MapsAndGuides
        public ActionResult Transportation()
        {
            return View("~/Views/Travel/Transportation.cshtml");
        }

        public ActionResult Seasons()
        {
            return View("~/Views/Travel/Seasons.cshtml");
        }
    }
}