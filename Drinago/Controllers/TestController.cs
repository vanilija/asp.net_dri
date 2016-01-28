using Drinago.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drinago.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

            public UserDB DB = new UserDB();

        public ActionResult Index()
        {
            bool i = DB.Open();

            if (i=true)
            {
                return Content(i.ToString());
            }

            else
            {
                return Content(i.ToString());
            }

            return View();
        }
    }
}