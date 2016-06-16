using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotWeb.WebApp.Controllers
{
    public class BecomeModelController : Controller
    {
        //
        // GET: /BecomeModel/

        public ActionResult BecomeModel()
        {
            ViewBag.BodyClass = "BecomeModel";
            return View();
        }

    }
}
