using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Data;
using System.IO;

using ProcCore.NetExtension;
using ProcCore.ReturnAjaxResult;

namespace DotWeb.Areas.Sys_Base.Controllers
{
    public class DocController : BaseController
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}
