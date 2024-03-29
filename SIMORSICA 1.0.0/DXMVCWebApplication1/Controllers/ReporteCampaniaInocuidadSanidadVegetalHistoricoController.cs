﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DXMVCWebApplication1.Controllers
{
    public class ReporteCampaniaInocuidadSanidadVegetalHistoricoController : Controller
    {
        //
        // GET: /ReporteCampaniaInocuidadSanidadVegetalHistorico/
        public ActionResult Index(string PK_IdCampania)
        {
            ViewData["PK_IdCampania"] = PK_IdCampania;
            return View();
        }

        DXMVCWebApplication1.Reports.ReporteCampaniaInocuidadSanidadVegetalHistorico report = new DXMVCWebApplication1.Reports.ReporteCampaniaInocuidadSanidadVegetalHistorico();

        [HttpPost]
        public ActionResult Report2Partial(string PK_IdCampania, int? Consecutivo_Repro)
        {
            ViewData["Consecutivo_Repro"] = Consecutivo_Repro;

            int IdAnio = Convert.ToInt32(Session["IdAnio"]);

            ViewData["PK_IdCampania"] = PK_IdCampania;
            report.Parameters["parameter1"].Value = PK_IdCampania;
            report.Parameters["parameter1"].Visible = false;
            report.Parameters["parameter2"].Visible = false;
            report.Parameters["parameter2"].Value = IdAnio;
            report.Parameters["parameter3"].Visible = false;
            report.Parameters["parameter3"].Value = Consecutivo_Repro;
            return PartialView("_Report2Partial", report);
        }

        [HttpPost]
        public ActionResult Report2PartialExport(int Consecutivo_Repro)
        {
            return DocumentViewerExtension.ExportTo(report, Request);
        }
    }
}