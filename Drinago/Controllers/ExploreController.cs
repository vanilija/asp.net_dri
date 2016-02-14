using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drinago.Controllers
{
    public class ExploreController : Controller
    {
        public ActionResult WhatToDo()
        {
            return View("~/Views/Explore/WhatToDo.cshtml");
        }

        public ActionResult WhatToSee()
        {
            return View("~/Views/Explore/WhatToSee.cshtml");
        }

        public ActionResult WhereToEat()
        {
            return View("~/Views/Explore/WhereToEat.cshtml");
        }

        public ActionResult WhereToShop()
        {
            return View("~/Views/Explore/WhereToShop.cshtml");
        }

        public ActionResult WhereToStay()
        {
            return View("~/Views/Explore/WhereToStay.cshtml");
        }
    }
}