﻿using System;
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
    public class AsiaController : WebFrontController
    {
        //
        // GET: /Asia/

        public AsiaController()
        {
            ViewBag.BodyClass = "Women";
        }

        public ActionResult Asia()
        {
            var qa = new a_ModelData() { Connection = getSQLConnection(), logPlamInfo = plamInfo };
            RunQueryPackage<m_ModelData> r = qa.SearchMaster(new q_ModelData() { s_isopen = true, s_division="Asia" }, 1);
            List<m_ModelData> rs = new List<m_ModelData>();
            for (int i = 0; i < r.Count; i++)
                rs.Add(r.SearchData[i]);
            return View(rs);
        }
    }
}
