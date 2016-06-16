using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using ProcCore;
using ProcCore.WebCore;
using ProcCore.NetExtension;
using ProcCore.Business.Logic;
using ProcCore.Business.Logic.TablesDescription;
using ProcCore.ReturnAjaxResult;
using ProcCore.JqueryHelp.JQGridScript;
using DotWeb.CommSetup;

namespace DotWeb.WebApp.Controllers
{
    public class ModelDetailController : WebFrontController
    {
        public ActionResult ModelDetail(int id)
        {
            var qa = new a_ModelData() { Connection = getSQLConnection(), logPlamInfo = plamInfo };
            RunOneDataEnd<m_ModelData> r = qa.GetDataMaster(id,2);
            m_ModelData rs = r.SearchData;
            return View(rs);
        }

    }
}
