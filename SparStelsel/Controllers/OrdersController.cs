using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SparStelsel.Models;
using Telerik.Web.Mvc;
using System.IO;
using Telerik.Web.Mvc.Extensions;
namespace SparStelsel.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/
        //Repository
        OrderRepository ORep = new OrderRepository();
        DropDownRepository DDRep = new DropDownRepository();
        SupplierRepository SRep = new SupplierRepository();
        ReportRepository reportrepo = new ReportRepository();
        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListOrders(string Pink = "")
        {
            return View(new GridModel(ORep.GetAllOrder(Pink)));
        }


        //Functions


        // CashBox 
        public ActionResult Orders()
        {
            ViewData["Supllier"] = DDRep.GetSupplierList();
            ViewData["Comments"] = DDRep.GetCommentList();
           
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertOrders(Order ins)
        {
            //...Insert Object
            Order ins2 = ORep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetAllOrder()));
        }
        //Update CashBox
        [GridAction]
        public JsonResult _UpdateOrders(Order ins)
        {
            //...Update Object
            Order ins2 = ORep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetAllOrder()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveOrders(int id)
        {
            ORep.Remove(id);

            //...Repopulate Grid...
            return View(new GridModel(ORep.GetAllOrder()));
        }

        public ActionResult OrdervsGRVReport()
        {
            ViewData["Month"] = reportrepo.GetMonthNameSelectList();
            ViewData["Year"] = reportrepo.GetYearSelectList();
            return View(new YearMonthQuery());
        }

        [HttpPost]
        public ActionResult GetOrdervsGRVReport(YearMonthQuery ins)
        {

            List<OrdervsGRVReport> report = reportrepo.GetOrdervsGRVReport(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Day\",\"Date\",\"Order Total\",\"Friday Total\",\"GRV Total\",\"Friday Total\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=OrdervsGRV_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (OrdervsGRVReport ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"",
                                           ex.Day
                                           , ex.Date
                                           , ex.OrderTotal
                                           , ex.FridayOrderTotal
                                           , ex.GRVTotal
                                           , ex.FridayGRVTotal));
            }

            //Response.ClearContent();
            //Response.AddHeader("content-disposition", "attachment;filename=MemberDetailReport_" + GroupName + "_" + name + ".zip");
            //Response.ContentType = "application/zip";

            Response.Write(sw.ToString());

            Response.End();

            return null;
        }
    }
}
