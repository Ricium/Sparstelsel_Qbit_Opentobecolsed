using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SparStelsel.Models;
using Telerik.Web.Mvc;
using System.IO;
using Telerik.Web.Mvc.Extensions;
using System.Data.OleDb;
using System.Text;
using System.Data;
using LinqToExcel;

namespace SparStelsel.Controllers
{
    [AutoLogOffActionFilter]
    public class GRVController : Controller
    {
        //
        // GET: /GRV/

        //Repository
        GRVListRepository GRVRep = new GRVListRepository();
        DropDownRepository DDRep = new DropDownRepository();
        SupplierRepository SupRep = new SupplierRepository();

        //Lists
        [GridAction]
        public ActionResult _ListGRVLists(string Invoice = "", string Pink = "", string Supplier = "", string From = "", string To = "")
        {
            return View(new GridModel(GRVRep.GetAllGRVList(Invoice, Pink, Supplier, DDRep.TelerikDateToString(From), DDRep.TelerikDateToString(To))));
        }

        [HttpPost]
        public ActionResult _GRVListGridExport(string Invoice = "", string Pink = "", string Supplier = "", string From = "", string To = "")
        {
            List<GRVList> report = GRVRep.GetAllGRVList(Invoice, Pink, Supplier, DDRep.TelerikDateToString(From), DDRep.TelerikDateToString(To));
            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Invoice Number\",\"State Date\",\"Number\",\"Pay Date\",\"Pink Slip Number\",\"GRV Date\",\"Invoice Date\",\"Excluding VAT\",\"VAT\",\"Including VAT\",\"Supplier\",\"Expected Paydate From Delivery Date\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=GRVList_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (GRVList ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\"",
                                           ex.InvoiceNumber.ToString()
                                           , ex.StateDate.ToShortDateString()
                                           , ex.Number.ToString()
                                           , ex.PayDate.ToShortDateString()
                                           , ex.PinkSlipNumber.ToString()
                                           , ex.GRVDate.ToShortDateString()
                                           , ex.InvoiceDate.ToShortDateString()
                                           , ex.ExcludingVat.ToString()
                                           , (ex.IncludingVat - ex.ExcludingVat).ToString()
                                           , ex.IncludingVat.ToString()                                           
                                           , ex.SupplierDetails
                                           , (ex.ExpectedPayDate == DateTime.MinValue) ? "No Order Linked To GRV" : ex.ExpectedPayDate.ToShortDateString()));
            }

            Response.Write(sw.ToString());
            Response.End();

            return null;
        }
    
        public ActionResult GRVLists()
        {
            ViewData["SupplierType"] = DDRep.GetSupplierTypeList();
            ViewData["SupplierID"] = DDRep.GetSupplierList();
            ViewData["AllSuplliers"] = DDRep.GetSupplierListWithAll();
            ViewData["GRVType"] = DDRep.GetGRVTypeList();

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertGRVLists(GRVList ins)
        {
            //...Insert Object
            ins.PayDate = GRVRep.GetPaymentDate(ins.SupplierID, ins.GRVDate);
            GRVList ins2 = GRVRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(GRVRep.GetAllGRVList()));
        }

        [GridAction]
        public JsonResult _UpdateGRVLists(GRVList ins)
        {
            //...Update Object
            GRVList ins2 = GRVRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(GRVRep.GetAllGRVList()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveGRVLists(int id)
        {
            //...Update Object
            GRVRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(GRVRep.GetAllGRVList()));
        }

        public ActionResult ImportGRVList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ImportFromExcel(FormCollection ins)
        {

            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["grv"];

                string extension = System.IO.Path.GetExtension(file.FileName);
                string path1 = string.Format("{0}/{1}", Server.MapPath("~/Includes/Files/"), Request.Files[0].FileName);
                if (System.IO.File.Exists(path1))
                    System.IO.File.Delete(path1);

                Request.Files[0].SaveAs(path1);

                var excel = new ExcelQueryFactory(path1);

                excel.AddMapping<GRVExcel>(x => x.InvNo, "Inv No");
                excel.AddMapping<GRVExcel>(x => x.REF, "REF");
                excel.AddMapping<GRVExcel>(x => x.Typ, "Typ");
                excel.AddMapping<GRVExcel>(x => x.Number, "Number");
                excel.AddMapping<GRVExcel>(x => x.Seq, "SeqNo");
                excel.AddMapping<GRVExcel>(x => x.GRVBook, "GRV Book");
                excel.AddMapping<GRVExcel>(x => x.GRVDate, "GRV Date");
                excel.AddMapping<GRVExcel>(x => x.InvDate, "Inv Date");
                excel.AddMapping<GRVExcel>(x => x.SupplierName, "Supplier Name");
                excel.AddMapping<GRVExcel>(x => x.ExclVAT, "Excl VAT");
                excel.AddMapping<GRVExcel>(x => x.VAT, "VAT");
                excel.AddMapping<GRVExcel>(x => x.InclVAT, "Incl VAT");

                var grvlist = from c in excel.Worksheet<GRVExcel>() select c;

                    //...Insert Batch...
                    GRVImport imp = new GRVImport();
                    imp.FileName = file.FileName;
                    imp = GRVRep.Insert(imp);

                    //...Set Data to Model List
                    List<GRVList> list = GRVRep.setData(grvlist, imp.BatchId);

                    //...Save List to Database...
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = GRVRep.InsertTemp(list[i]);
                    }

                    //...Display Imported Values
                    return RedirectToAction("GRVImportBatch", new { BatchId = imp.BatchId });

            }

            return RedirectToAction("GRVLists");
            //return RedirectToAction("MemberImport");
        }

        [GridAction]
        public ActionResult _ListImports()
        {
            return View(new GridModel(GRVRep.GetAllGRVImports()));
        }

     
        public ActionResult _UpdateImport(int id)
        {
            return RedirectToAction("GRVImportBatch", new { BatchId = id });
        }

        public ActionResult _RemoveImport()
        {
            return null;
        }
        
        [GridAction]
        public ActionResult _ListGRVBatch(int BatchId)
        {
            return View(new GridModel(GRVRep.GetAllGRVList(BatchId)));
        }

        public ActionResult GRVImportBatch(int BatchId)
        {
            ViewData["BatchId"] = BatchId;
            ViewData["SupplierType"] = DDRep.GetSupplierTypeList();
            ViewData["Suppliers"] = DDRep.GetSupplierList();
            return View();
        }

        [GridAction]
        public JsonResult _AddSupplier(GRVListImport ins)
        {
            //...Update Object
            if (ins.SupplierID == 0)
            {
                //...Insert Supplier
                Supplier sup = new Supplier();
                sup.CompanyID = 0;
                sup.CreatedDate = DateTime.Now;
                sup.FromFriday = ins.FromFriday;
                sup.StockCondition = ins.StockCondition;
                sup.Suppliers = ins.Suppliers;
                sup.SupplierTypeID = ins.SupplierTypeID;
                sup.Term = ins.Term;

                sup = SupRep.Insert(sup);
                ins.SupplierID = sup.SupplierID;
                ins.hasError = (ins.SupplierID == 0) ? true: false;
                GRVListImport ins2 = GRVRep.UpdateTemp(ins);
                                
                //...Update all similair
                GRVRep.UpdateImports();
            }
            else
            {
                //...Update only single one
                ins.hasError = (ins.SupplierID == 0) ? true : false;
                GRVListImport ins2 = GRVRep.UpdateTemp(ins);

                GRVRep.UpdateImports();
            }

            //...Repopulate Grid...
            return Json(new GridModel(GRVRep.GetAllGRVList(ins.BatchId)));
        }

        public ActionResult GRVImportProcess(int BatchId)
        {
            List<GRVListImport> all = GRVRep.GetAllGRVList(BatchId);

            foreach (GRVListImport imp in all)
            {
                if (!imp.hasError)
                {
                    GRVList ins = GRVRep.ConvertToOther(imp);
                    ins = GRVRep.Insert(ins);
                    GRVRep.RemoveTemp(imp.GRVListID);
                }
            }

            return RedirectToAction("GRVLists");
        }

    }


}
