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
using System.Globalization;

namespace SparStelsel.Controllers
{
    [AutoLogOffActionFilter]
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
            sw.WriteLine("\"Pink Slip Number\",\"Supplier\",\"Order Date\",\"Order Total\",\"Last GRV Date\",\"GRV Total\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=GRV_Totals_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (PinkslipGRVReport ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"",
                                           ex.PinkslipNumber
                                           , ex.Supplier
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

        public ActionResult PaymentReport()
        {
            ViewData["Supllier"] = DDRep.GetSupplierListWithSpecialAll();
            ViewData["CashType"] = DDRep.GetCashTypeListWithSpecialAll();
            return View(new PaymentQuery());
        }

        [HttpPost]
        public ActionResult GetPaymentReport(PaymentQuery ins)
        {
            List<PaymentReport> report = reportrepo.GetPaymentReport(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Invoice Number \",\"Pink Slip Number\",\"Supplier\",\"Expected Pay Date\",\"Pay By Date\",\"Invoice Date\",\"State Date\",\"Actual Payment Date\","
                + "\"Payment Comment\",\"Payment Method\",\"Exculding Vat\",\"Including Vat\",\"Payment Amount\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            DateTime checker = new DateTime(1900, 1, 1);

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Payments_from_" + ins.FromDate.ToShortDateString() + "_" + name + ".csv");
            Response.ContentType = "text/csv";

            sw.WriteLine("\"Paid\"");
            foreach (PaymentReport ex in report)
            {
                if (!ex.ActualDate.Equals(checker.ToShortDateString()))
                {
                    sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"",
                                               ex.InvoiceNumber
                                               , ex.PinkSlipNumber
                                               , ex.Supplier
                                               , ex.ExpectedPayDate
                                               , ex.PayDate
                                               , ex.InvoiceDate
                                               , ex.StateDate
                                               , ex.ActualDate
                                               , ex.PaymentDescription
                                               , ex.CashType
                                               , ex.ExcludingVat
                                               , ex.IncludingVat
                                               , ex.Amount
                                               ));
                }
            }

            sw.WriteLine("\" \"");
            sw.WriteLine("\"Unpaid\"");
            foreach (PaymentReport ex in report)
            {
                if (ex.ActualDate.Equals(checker.ToShortDateString()))
                {
                    sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"",
                                               ex.InvoiceNumber
                                               , ex.PinkSlipNumber
                                               , ex.Supplier
                                               , ex.ExpectedPayDate
                                               , ex.PayDate
                                               , ex.InvoiceDate
                                               , ex.StateDate
                                               , "Unpaid" //ex.ActualDate
                                               , ex.PaymentDescription
                                               , ex.CashType
                                               , ex.ExcludingVat
                                               , ex.IncludingVat
                                               , ex.Amount
                                               ));
                }
            }

            Response.Write(sw.ToString());
            Response.End();
            return null;
        }

        public ActionResult DayEndCashupReport()
        {
            return View(new DayEndCashupQuery());
        }

        [HttpPost]
        public ActionResult GetDayEndCashupReport(DayEndCashupQuery ins)
        {
            DayEndCashupReport report = reportrepo.GetDayEndCashupReport(ins);
            decimal ExpectedClosing = ins.OpeningBalance + report.SigmaTotal 
                                       + report.CounterTotal + report.Change 
                                        - ins.PettyCash - report.SassaTotal - report.Cashbox 
                                        - report.Transits;
            decimal Shortage = report.CashReceived - report.StartUpFloats - report.SigmaTotal;

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Opening Balance\",\"{0}\"", ins.OpeningBalance);
            sw.WriteLine("\"Sigma Cash Sales\",\"{0}\"", report.SigmaTotal);
            sw.WriteLine("\"Cash Counter Netto\",\"{0}\"", report.CounterTotal);
            sw.WriteLine("\"Change Movement\",\"{0}\"", report.Change);
            sw.WriteLine("\"Cash transactions (Petty cash Total)\",\"{0}\"", ins.PettyCash);
            sw.WriteLine("\"Sassa Payouts\",\"{0}\"", report.SassaTotal);
            sw.WriteLine("\"Total dropped in Cashbox for today\",\"{0}\"", report.Cashbox);
            sw.WriteLine("\"Transits\",\"{0}\"", report.Transits);
            sw.WriteLine("\"Expected Closing Balance\",\"{0}\"", ExpectedClosing);
            sw.WriteLine("\"Actual Cash\",\"{0}\"", report.ActualCash);
            sw.WriteLine("\"Day End: {0}\",\"{1}\"", (((ExpectedClosing - report.ActualCash) < 0) ? "Shortage" : "Over"), (ExpectedClosing - report.ActualCash));
            sw.WriteLine("\" \"");
            sw.WriteLine("\"SIGMA CASHIER - CASH RECON\"");
            sw.WriteLine("\"Cash Expected\",\"{0}\"", report.SigmaTotal);
            sw.WriteLine("\"Cash Received\",\"{0}\"", report.CashReceived);
            sw.WriteLine("\"Startup Floats\",\"{0}\"", report.StartUpFloats);
            sw.WriteLine("\"Shortage\",\"{0}\"", Shortage);
            sw.WriteLine("\"Sassa Payouts\",\"{0}\"", report.SassaTotal);
            sw.WriteLine("\"{0}\",\"{1}\"", (((Shortage + report.SassaTotal) > 0) ? "Over" : "Short"), (Shortage + report.SassaTotal));
            sw.WriteLine("\" \"");
            sw.WriteLine("\"SIGMA CASHIER - CARD RECON\"");
            sw.WriteLine("\"Sigma Cards Expected\",\"{0}\"", ins.SigmaCardsExpected);
            sw.WriteLine("\"Declared Slips Total\",\"{0}\"", report.DeclaredSlips);
            sw.WriteLine("\"CARDS NOT CAPTURED\",\"{0}\"", (ins.SigmaCardsExpected - report.DeclaredSlips));
            sw.WriteLine("\" \"");
            sw.WriteLine("\"PAYZONE CASHIERS\"");
            sw.WriteLine("\"Cash Expected\",\"{0}\"", report.CounterTotal);
            sw.WriteLine("\"Cash Received\",\"{0}\"", report.CashDeclared);
            sw.WriteLine("\"{0}\",\"{1}\"", (((report.CashDeclared - report.CounterTotal) > 0) ? "Over" : "Short"), (report.CashDeclared - report.CounterTotal));


            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=DayEndCashup_" + ins.Date.ToShortDateString() + "_" + name + ".csv");
            Response.ContentType = "text/csv";

            Response.Write(sw.ToString());
            Response.End();
            return null;
        }

        public ActionResult CashOfficeReport()
        {
            return View(new DateTimeFromToQuery());
        }

        [HttpPost]
        public ActionResult GetCashOfficeReport(DateTimeFromToQuery ins)
        {
            List<CashOfficeReport> report = reportrepo.GetCashOfficeReport(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Money Unit\",\"Sealed\",\"Opened\",\"Notes\",\"Cashiers\",\"Total\",\"Drops\",\"Transits\","
                + "\"Day End Balance\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Cashoffice" + "_" + name + ".csv");
            Response.ContentType = "text/csv";

            decimal notestotal = 0;
            decimal cashiertotal = 0;
            decimal droptotal = 0;
            decimal trasittotal = 0;
            
            foreach (CashOfficeReport ex in report)
            {
                notestotal += ex.Sealed + ex.Opened + ex.TotalInOffice;
                cashiertotal += ex.CashierTotal;
                droptotal += ex.Drop;
                trasittotal += 0;

                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\"",
                                           ex.MoneyUnit
                                           , ex.Sealed
                                           , ex.Opened
                                           , (ex.Sealed + ex.Opened + ex.TotalInOffice)
                                           , ex.CashierTotal 
                                           , (ex.Sealed + ex.Opened + ex.TotalInOffice + ex.CashierTotal)
                                           , ex.Drop
                                           , 0
                                           , (ex.Sealed + ex.Opened + ex.TotalInOffice + ex.CashierTotal - ex.Drop - 0)
                                           ));
            }

            decimal pickuptotal = reportrepo.GetPickUpTotal(ins.From);
           
            sw.WriteLine(", , ,{0},{1},{2},{3},{4},{5}"
                , notestotal, cashiertotal, (notestotal + cashiertotal), droptotal, trasittotal, (notestotal + cashiertotal - droptotal - trasittotal));

            sw.WriteLine("\" \"");
            sw.WriteLine(", , , , , , ,\"Total Pickups\",\"{0}\"", pickuptotal);
            sw.WriteLine(", , , , , , ,\"Day end Total\",\"{0}\"", (notestotal + cashiertotal - droptotal - trasittotal + pickuptotal));

            Response.Write(sw.ToString());
            Response.End();
            return null;
        }

        public ActionResult CashierReport()
        {
            ViewData["Cashiers"] = DDRep.GetEmployeeList();
            return View(new CashierReportQuery());
        }

        [HttpPost]
        public ActionResult GetCashierReport(CashierReportQuery ins)
        {
            CashierReport report = reportrepo.GetCashierReport(ins);

            return View(report);
        }

        [HttpPost]
        public ActionResult GetCashierReportPDF(int CashierId, DateTime ReportDate)
        {
            CashierReportQuery query = new CashierReportQuery();
            query.Cashier = CashierId;
            query.Date = ReportDate;

            CashierReport report = reportrepo.GetCashierReport(query);

            return new Rotativa.ViewAsPdf("CashierReportPDF", report);
        }

        public ActionResult SparReconReport()
        {
            return View(new DateTimeFromToQuery());
        }

        [HttpPost]
        public ActionResult GetSparReconReport(DateTimeFromToQuery ins)
        {
            List<SparReconReport> report = reportrepo.GetSparReconReport(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Status\",\"GRV Invoice Number\",\"GRV Date\",\"GRV Pay Date\",\"Excluding VAT\",\"Including VAT\",\"Pink Slip Number\",\"GRV Type\" "
                +" ,\"Supplier\",\"Recon Invoice Number\",\"Recon GRV Date\", Recon Amount, Recon GRV Type");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=SparInvoiceRecon" + "_" + name + ".csv");
            Response.ContentType = "text/csv";

            sw.WriteLine("\"GRV's not on Spar Invoice\"");

            foreach (SparReconReport ex in report)
            {
                if (ex.ReconInvoiceNumber.Equals("No GRV"))
                {
                    sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"",
                                          "No Recon"
                                          , ex.GRVInvoiceNumber
                                          , ex.GRVDate
                                          , ex.GRVPayDate
                                          , ex.GRVExVAT
                                          , ex.GRVInVAT
                                          , ex.GRVPinkSlipNumber
                                          , (ex.GRVType.Equals("1")) ? "GRV" : "CLM"
                                          , ex.Supplier
                                          , ""
                                          , ""
                                          , ""
                                          , ""
                                          ));
                }
            }

            sw.WriteLine("\" \"");
            sw.WriteLine("\"Spar Invoices not in GRV List\"");

            foreach (SparReconReport ex in report)
            {
                if (ex.GRVInvoiceNumber.Equals("No Recon"))
                {
                    sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"",
                                          ex.Status
                                          , ""
                                          , ""
                                          , ""
                                          , ""
                                          , ""
                                          , ""
                                          , ""
                                          , ex.Supplier
                                          , ex.ReconInvoiceNumber
                                          , ex.ReconDate
                                          , ex.ReconAmount
                                          , (ex.ReconType.Equals("1")) ? "GRV" : "CLM"
                                          ));
                }               
            }

            sw.WriteLine("\" \"");
            sw.WriteLine("\"Matched on GRV List and Spar Invoice\"");

            foreach (SparReconReport ex in report)
            {
                if ((!ex.GRVInvoiceNumber.Equals("No Recon")) && (!ex.ReconInvoiceNumber.Equals("No GRV")))
                {
                    sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"",
                                          ex.Status
                                          , ex.GRVInvoiceNumber
                                          , ex.GRVDate
                                          , ex.GRVPayDate
                                          , ex.GRVExVAT
                                          , ex.GRVInVAT
                                          , ex.GRVPinkSlipNumber
                                          , (ex.GRVType.Equals("1")) ? "GRV" : "CLM"
                                          , ex.Supplier
                                          , ex.ReconInvoiceNumber
                                          , ex.ReconDate
                                          , ex.ReconAmount
                                          , (ex.ReconType.Equals("1")) ? "GRV" : "CLM"
                                          ));
                }
            }

            
            Response.Write(sw.ToString());
            Response.End();
            return null;
        }

    }
}
