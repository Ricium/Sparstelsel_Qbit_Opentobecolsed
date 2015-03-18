using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SparStelsel.Models;
using Telerik.Web.Mvc;
using System.IO;
using Telerik.Web.Mvc.Extensions;
using System.Globalization;

namespace SparStelsel.Controllers
{
    public class SparReconController : Controller
    {
        public DropDownRepository DDRep = new DropDownRepository();
        public SparReconRepository ReconRep = new SparReconRepository();
        public GRVListRepository GRVRep = new GRVListRepository();

        public ActionResult _GetInvoices(DateTime InvoiceDate, int SupplierId = 0)
        {
            List<string> InvoiceNumbers = ReconRep.GetAutoCompleteInvoiceNumbers(InvoiceDate, SupplierId);
            return new JsonResult { Data = (IEnumerable<String>)InvoiceNumbers };
        }

        public ActionResult _GetInvoiceAmount(DateTime InvoiceDate, int SupplierId = 0, string InvoiceNumber = "")
        {
            return Content(DDRep.GetInvoiceAmount(InvoiceDate, SupplierId, InvoiceNumber).ToString(), "text");
        }

        [GridAction]
        public ActionResult _GetRecons()
        {
            return View(new GridModel(ReconRep.GetRecons()));
        }

        [GridAction]
        public JsonResult _Insert(SparInvoiceRecon ins)
        {
            //...Fix InvoiceNumber
            InvoiceNumberGRVType data = ReconRep.FilterInvoiceNumber(ins.InvoiceNumber);
            ins.InvoiceNumber = data.InvoiceNumber;
            ins.GRVTypeId = data.GRVTypeId;
            GRVRep.UpdateStateDate(ins.GRVDate, ins.InvoiceNumber, ins.SupplierId, ins.GRVTypeId);
            SparInvoiceRecon ins2 = ReconRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ReconRep.GetRecons()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _Update(SparInvoiceRecon ins)
        {
            //...Fix InvoiceNumber
            
            if((ins.InvoiceNumber.Contains(" - GRV")) || (ins.InvoiceNumber.Contains(" - CLM")))
            {
                InvoiceNumberGRVType data = ReconRep.FilterInvoiceNumber(ins.InvoiceNumber);
                ins.InvoiceNumber = data.InvoiceNumber;
                ins.GRVTypeId = data.GRVTypeId;
            }
            GRVRep.UpdateStateDate(ins.GRVDate, ins.InvoiceNumber,ins.SupplierId, ins.GRVTypeId);
            SparInvoiceRecon ins2 = ReconRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ReconRep.GetRecons()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _Remove(int id)
        {
            //...Update Object
            ReconRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(ReconRep.GetRecons()));
        }

        public ActionResult SparInvoiceRecon()
        {
            ViewData["Suppliers"] = DDRep.GetSupplierList();
            return View();
        }
    }
}
