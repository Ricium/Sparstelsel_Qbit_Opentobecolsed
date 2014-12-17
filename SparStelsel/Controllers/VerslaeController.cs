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
    public class VerslaeController : Controller
    {
        DropDownRepository DDRep = new DropDownRepository();
        ReportRepository reportrepo = new ReportRepository();

        public ActionResult OrdervsGRVReport()
        {
            return View(new DateTimeFromToQuery());
        }

        [HttpPost]
        public ActionResult GetOrdervsGRVReport(DateTimeFromToQuery ins)
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

            Response.Write(sw.ToString());
            Response.End();
            return null;
        }

        public ActionResult PinkSlipOrderReport()
        {
            return View(new NumericalRangeQuery());
        }

        [HttpPost]
        public ActionResult GetPinkslipOrderReport(NumericalRangeQuery ins)
        {
            List<PinkslipOrderReport> report = reportrepo.GetPinkslipRange(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Pink Slip Number\",\"Order Date\",\"Expeceted Delivery Date\",\"Order Total\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Pinkslip_Orders_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (PinkslipOrderReport ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\"",
                                           ex.PinkslipNumber
                                           , ex.OrderDate
                                           , ex.ExpectedDeliveryDate
                                           , ex.OrderTotal
                                           ));
            }

            Response.Write(sw.ToString());
            Response.End();
            return null;
        }

        public ActionResult PinkSlipGRVReport()
        {
            return View(new NumericalRangeQuery());
        }

        [HttpPost]
        public ActionResult GetPinkslipGRVReport(NumericalRangeQuery ins)
        {
            List<PinkslipGRVReport> report = reportrepo.GetPinkslipGRVRange(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Pink Slip Number\",\"Order Date\",\"Order Total\",\"Last GRV Date\",\"GRV Total\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=GRV_Totals_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (PinkslipGRVReport ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\"",
                                           ex.PinkslipNumber
                                           , ex.OrderDate
                                           , ex.OrderTotal
                                           , ex.GRVDate
                                           , ex.GRVTotal
                                           ));
            }

            Response.Write(sw.ToString());
            Response.End();
            return null;
        }

        public ActionResult OrdersExpectedDateReport()
        {
            return View(new DateTimeFromToQuery());
        }

        [HttpPost]
        public ActionResult GetOrdersExpectedDateReport(DateTimeFromToQuery ins)
        {
            List<PinkslipOrderReport> report = reportrepo.GetOrdersPerExpectedDeliveryDate(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Pink Slip Number\",\"Order Date\",\"Order Total\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Orders_for_" + ins.From.ToShortDateString() + "_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (PinkslipOrderReport ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\"",
                                           ex.PinkslipNumber
                                           , ex.OrderDate
                                           , ex.OrderTotal
                                           ));
            }

            Response.Write(sw.ToString());
            Response.End();
            return null;
        }
    }
}
