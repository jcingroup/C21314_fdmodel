using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotWeb.WebApp.Controllers
{
    public class ContactUsController : Controller
    {
        //
        // GET: /ContactUs/

        public ActionResult ContactUs()
        {
            ViewBag.BodyClass = "ContactUs";
            return View();
        }

    }
}
