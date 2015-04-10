using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class ReportRepository
    {
        public List<OrdervsGRVReport> GetOrdervsGRVReport(YearMonthQuery query)
        {
            List<OrdervsGRVReport> lst = new List<OrdervsGRVReport>();
            OrdervsGRVReport ins;

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand();
            cmdI.CommandTimeout = 540;
            cmdI.Connection = con;
            cmdI.CommandText = "f_Admin_Report_OrdersvsGRVPerDay";
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@month", query.Month);                  // int,
            cmdI.Parameters.AddWithValue("@year", query.Year);                // int
            cmdI.Connection.Open();

            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new OrdervsGRVReport();
                    ins.Date = Convert.ToDateTime(drI["Date"]).ToShortDateString();
                    ins.GRVTotal = drI["GRVAmount"].ToString();
                    ins.OrderTotal = drI["OrderAmount"].ToString();
                    lst.Add(ins);
                }
            }

            DateTime parser;
            decimal ortotal = 0;
            decimal grvtotal = 0;

            foreach (OrdervsGRVReport item in lst)
            {
                DateTime.TryParse(item.Date, out parser);
                item.Day = parser.DayOfWeek.ToString();
                ortotal += Convert.ToDecimal(item.OrderTotal);
                grvtotal += Convert.ToDecimal(item.GRVTotal);

                if(parser.DayOfWeek == DayOfWeek.Friday)
                {
                    item.FridayOrderTotal = ortotal.ToString();
                    item.FridayGRVTotal = grvtotal.ToString();
                    ortotal = 0;
                    grvtotal = 0;
                }
                else
                {
                    item.FridayGRVTotal = "";
                    item.FridayOrderTotal = "";
                }
            }

            cmdI.Connection.Close();
            con.Dispose();

            return lst;
        }

        public List<OrdervsGRVReport> GetOrdervsGRVReport(DateTimeFromToQuery query)
        {
            string FromDate = query.From.ToString();
            string ToDate = query.To.ToString();

            if(query.To.Year.Equals(1))
            {
                ToDate = "2050-01-01";      //...Max date of Report (Can be changed anytime)
            }

            List<OrdervsGRVReport> lst = new List<OrdervsGRVReport>();
            OrdervsGRVReport ins;

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand();
            cmdI.CommandTimeout = 540;
            cmdI.Connection = con;
            cmdI.CommandText = "f_Admin_Report_OrdersvsGRVPerDay";
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@FromDate", FromDate);                 
            cmdI.Parameters.AddWithValue("@ToDate", ToDate);               
            cmdI.Connection.Open();

            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new OrdervsGRVReport();
                    ins.Date = Convert.ToDateTime(drI["Date"]).ToShortDateString();
                    ins.GRVTotal = drI["GRVAmount"].ToString();
                    ins.OrderTotal = drI["OrderAmount"].ToString();
                    lst.Add(ins);
                }
            }

            DateTime parser;
            decimal ortotal = 0;
            decimal grvtotal = 0;

            foreach (OrdervsGRVReport item in lst)
            {
                DateTime.TryParse(item.Date, out parser);
                item.Day = parser.DayOfWeek.ToString();
                ortotal += Convert.ToDecimal(item.OrderTotal);
                grvtotal += Convert.ToDecimal(item.GRVTotal);

                if (parser.DayOfWeek == DayOfWeek.Friday)
                {
                    item.FridayOrderTotal = ortotal.ToString();
                    item.FridayGRVTotal = grvtotal.ToString();
                    ortotal = 0;
                    grvtotal = 0;
                }
                else
                {
                    item.FridayGRVTotal = "";
                    item.FridayOrderTotal = "";
                }
            }

            cmdI.Connection.Close();
            con.Dispose();

            return lst;
        }

        public List<PinkslipOrderReport> GetPinkslipRange(NumericalRangeQuery query)
        {
            //...Create New Instance of Object...
            List<PinkslipOrderReport> list = new List<PinkslipOrderReport>();
            PinkslipOrderReport ins;

            if(query.To == 0)
            {
                query.To = 9999999;
            }

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("select * from t_Order o "
                                    + " where o.Removed = 0 AND o.PinkSlipNumber >= " + query.From 
                                    + " AND o.PinkSlipNumber <= " + query.To, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new PinkslipOrderReport();
                    ins.PinkslipNumber = drI["PinkSlipNumber"].ToString();
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]).ToShortDateString();
                    ins.ExpectedDeliveryDate = Convert.ToDateTime(drI["ExpectedDeliveryDate"]).ToShortDateString();
                    ins.OrderTotal = drI["Amount"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();

            //...Return...
            return list;
        }

        public List<PinkslipGRVReport> GetPinkslipGRVRange(NumericalRangeQuery query)
        {
            //...Create New Instance of Object...
            List<PinkslipGRVReport> list = new List<PinkslipGRVReport>();
            PinkslipGRVReport ins;

            if (query.To == 0)
            {
                query.To = 9999999;
            }

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("select o.PinkSlipNumber, s.Supplier, o.OrderDate"
                                    + " ,o.Amount as OrderAmount"
                                    + " ,SUM(g.IncludingVat) as GRVTotal"
                                    + " ,(SELECT TOP 1 t.GRVDate FROM t_GRVList t WHERE t.PinkSlipNumber = o.PinkSlipNumber ORDER BY t.GRVDate DESC) as LastDate"
                                    + " from t_Order o inner join t_GRVList g on o.PinkSlipNumber = g.PinkSlipNumber"
                                    + " inner join t_Supplier s on o.SupplierID = s.SupplierID"
                                    + " where o.PinkSlipNumber >= " + query.From + " and o.PinkSlipNumber <= " + query.To
                                    + " Group by o.PinkSlipNumber, s.Supplier, o.OrderDate, o.Amount", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new PinkslipGRVReport();
                    ins.PinkslipNumber = drI["PinkSlipNumber"].ToString();
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]).ToShortDateString();
                    ins.GRVDate = Convert.ToDateTime(drI["LastDate"]).ToShortDateString();
                    ins.OrderTotal = drI["OrderAmount"].ToString();
                    ins.GRVTotal = drI["GRVTotal"].ToString();
                    ins.Supplier = drI["Supplier"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();

            //...Return...
            return list;
        }

        public List<PinkslipOrderReport> GetOrdersPerExpectedDeliveryDate(DateTimeFromToQuery query)
        {
            //...Create New Instance of Object...
            List<PinkslipOrderReport> list = new List<PinkslipOrderReport>();
            PinkslipOrderReport ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("select * from t_Order o "
                    + " where DATEPART(DAY,o.ExpectedDeliveryDate) = " + query.From.Day
                    + " AND DATEPART(MONTH,o.ExpectedDeliveryDate) = " + query.From.Month
                    + " AND DATEPART(YEAR, o.ExpectedDeliveryDate) = " + query.From.Year, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new PinkslipOrderReport();
                    ins.PinkslipNumber = drI["PinkSlipNumber"].ToString();
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]).ToShortDateString();
                    ins.OrderTotal = drI["Amount"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();

            //...Return...
            return list;
        }

        public DayEndCashupReport GetDayEndCashupReport(DayEndCashupQuery query)
        {
            //...Create New Instance of Object...
            DayEndCashupReport ins = new DayEndCashupReport();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand();
            cmdI.CommandTimeout = 540;
            cmdI.Connection = con;
            cmdI.CommandText = "f_Admin_Report_DayEndCashUp";
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@date", query.Date);

            cmdI.Connection.Open();

            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.ActualCash = Convert.ToDecimal(drI["ActualCash"]);
                    ins.Cashbox = Convert.ToDecimal(drI["Cashbox"]);
                    ins.CashDeclared = Convert.ToDecimal(drI["CashDeclared"]);
                    ins.CashReceived = Convert.ToDecimal(drI["CashReceived"]);
                    ins.Change = Convert.ToDecimal(drI["Change"]);
                    ins.CounterTotal = Convert.ToDecimal(drI["CounterTotal"]);
                    ins.DeclaredSlips = Convert.ToDecimal(drI["DeclaredSlips"]);
                    ins.SassaTotal = Convert.ToDecimal(drI["SassaTotal"]);
                    ins.SigmaTotal = Convert.ToDecimal(drI["SigmaTotal"]);
                    ins.StartUpFloats = Convert.ToDecimal(drI["StartUpFloats"]);
                    ins.Transits = Convert.ToDecimal(drI["Transits"]);
                }
            }

            //...Close Connections...
            cmdI.Connection.Close();
            con.Dispose();

            //...Return...
            return ins;
        }

        public List<PaymentReport> GetPaymentReport(PaymentQuery query)
        {
            //...Create New Instance of Object...
            List<PaymentReport> list = new List<PaymentReport>();
            PaymentReport ins;

            if (query.ToDate.Year.Equals(1))
            {
                query.ToDate = new DateTime(2015, 12, 31); ;     //...Max date of Report (Can be changed anytime)
            }

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            /*
              "Select g.InvoiceNumber, g.PinkSlipNumber, g.ExpectedPayDate, g.PayDate, g.InvoiceDate, g.StateDate "
                + ", p.ActualDate, p.PaymentDescription, c.CashType, g.ExcludingVat, g.IncludingVat, p.Amount, s.Supplier "
                + " from t_GRVList g "
                + "	inner join t_ProofOfPayment p on g.InvoiceNumber = p.InvoiceNumber "
                + "	inner join t_Supplier s on g.SupplierID = s.SupplierID"
                + "	inner join l_CashType c on p.CashTypeID = c.CashTypeID "
                    + "	where p.ActualDate >= '" + query.FromDate.ToShortDateString() + "' "
                    + "	and p.ActualDate <= '" + query.ToDate.ToShortDateString() + "' "
                    + "	and g.InvoiceNumber LIKE '%" + query.InvoiceNumber + "' "
                    + "	and g.PinkSlipNumber LIKE '%" + query.PinkSlip + "' "
                    + "	and p.CashTypeID LIKE '%" + query.Paymenthod + "' "
                    + "	and g.SupplierID LIKE '%" + query.Supplier + "'"
             */

            //...SQL Commands...
            cmdI = new SqlCommand("Select g.InvoiceNumber, g.PinkSlipNumber, g.ExpectedPayDate, g.PayDate, g.InvoiceDate, g.StateDate "
                            + " , COALESCE(p.ActualDate,'') as ActualDate "
                            + " , COALESCE(p.PaymentDescription,'') as PaymentDescription "
                            + " , COALESCE(c.CashType,'') as CashType "
                            + " , g.ExcludingVat, g.IncludingVat "
                            + " , COALESCE(p.Amount,0) as Amount "
                            + " , s.Supplier  "
                            + " from t_GRVList g  "
                            + " left join t_ProofOfPayment p on g.InvoiceNumber = p.InvoiceNumber  "
                            + " inner join t_Supplier s on g.SupplierID = s.SupplierID "
                            + " left join l_CashType c on p.CashTypeID = c.CashTypeID  "
                            + " where   "
                            + " g.InvoiceNumber LIKE '%" + query.InvoiceNumber + "' "
                            + " and (g.PayDate >= '" + query.FromDate.ToShortDateString() + "' "
                            + " and g.PayDate <= '" + query.ToDate.ToShortDateString() + "' "
                            //+ " and s.SupplierTypeID = 2 )"
                            + (query.Supplier.Equals("%") ? "" : " and g.SupplierID = " + query.Supplier)
                            + ")"
                            + " or ( p.ActualDate >= '" + query.FromDate.ToShortDateString() + "' " 
                            + " and p.ActualDate <= '" + query.ToDate.ToShortDateString() + "' "
                            //+ " and s.SupplierTypeID = 2 )"
                            + (query.Supplier.Equals("%") ? "" : " and g.SupplierID = " + query.Supplier)
                            + ")"
                            + " and g.PinkSlipNumber LIKE '%" + query.PinkSlip + "' "
                            + " and COALESCE(p.CashTypeID,'') LIKE '%" + query.Paymenthod + "' "
                            
                            //+ " and g.SupplierID LIKE '%" + query.Supplier + "'"
                            
                            + " ORDER BY p.ActualDate DESC, s.Supplier", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new PaymentReport();
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]).ToShortDateString();
                    ins.Amount = drI["Amount"].ToString();
                    ins.CashType = drI["CashType"].ToString();
                    ins.ExcludingVat = drI["ExcludingVat"].ToString();
                    ins.ExpectedPayDate = Convert.ToDateTime(drI["ExpectedPayDate"]).ToShortDateString();
                    ins.IncludingVat = drI["IncludingVat"].ToString();
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]).ToShortDateString();
                    ins.InvoiceNumber = drI["InvoiceNumber"].ToString();
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]).ToShortDateString();
                    ins.PaymentDescription = drI["PaymentDescription"].ToString();
                    ins.PinkSlipNumber = drI["PinkSlipNumber"].ToString();
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]).ToShortDateString();
                    ins.Supplier = drI["Supplier"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();

            //...Return...
            return list;
             
        }

        public List<SelectListItem> GetMonthNameSelectList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            var result1 = new SelectListItem();
            result1.Text = "January";
            result1.Value = "1";
            obj.Add(result1);

            var result2 = new SelectListItem();
            result2.Text = "February";
            result2.Value = "2";
            obj.Add(result2);

            var result3 = new SelectListItem();
            result3.Text = "March";
            result3.Value = "3";
            obj.Add(result3);

            var result4 = new SelectListItem();
            result4.Text = "April";
            result4.Value = "4";
            obj.Add(result4);

            var result5 = new SelectListItem();
            result5.Text = "May";
            result5.Value = "5";
            obj.Add(result5);

            var result6 = new SelectListItem();
            result6.Text = "June";
            result6.Value = "6";
            obj.Add(result6);

            var result7 = new SelectListItem();
            result7.Text = "July";
            result7.Value = "7";
            obj.Add(result7);

            var result8 = new SelectListItem();
            result8.Text = "August";
            result8.Value = "8";
            obj.Add(result8);

            var result9 = new SelectListItem();
            result9.Text = "September";
            result9.Value = "9";
            obj.Add(result9);

            var result10 = new SelectListItem();
            result10.Text = "October";
            result10.Value = "10";
            obj.Add(result10);

            var result11 = new SelectListItem();
            result11.Text = "November";
            result11.Value = "11";
            obj.Add(result11);

            var result12 = new SelectListItem();
            result12.Text = "December";
            result12.Value = "12";
            obj.Add(result12);

            return obj;
        }

        public List<SelectListItem> GetYearSelectList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            for (int i = DateTime.Now.Year; i >= 2010; i--)
            {
                var result = new SelectListItem();
                result.Text = Convert.ToString(i);
                result.Value = Convert.ToString(i);
                obj.Add(result);
            }

            return obj;
        }

        public decimal GetPickUpTotal(DateTime date)
        {
            decimal total = 0;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("Select SUM(Amount) as Total from t_PickUp where ActualDate = '" + date.ToShortDateString() + "' and Removed = 0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    total = Convert.ToDecimal(drI["Total"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();

            return total;
        }

        public List<CashOfficeReport> GetCashOfficeReport(DateTimeFromToQuery query)
        {
            //...Create New Instance of Object...
            List<CashOfficeReport> list = new List<CashOfficeReport>();
            CashOfficeReport ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand();
            cmdI.CommandTimeout = 540;
            cmdI.Connection = con;
            cmdI.CommandText = "f_Admin_Report_CashOffice";
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@SelectedDate", query.From);

            cmdI.Connection.Open();

            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashOfficeReport();
                    ins.MoneyUnit = drI["MoneyUnit"].ToString();
                    ins.Sealed = Convert.ToDecimal(drI["Sealed"]);
                    ins.Opened = Convert.ToDecimal(drI["Opened"]);
                    ins.TotalInOffice = Convert.ToDecimal(drI["Notes"]);
                    ins.CashierTotal = Convert.ToDecimal(drI["Cashiers"]);
                    ins.Drop = Convert.ToDecimal(drI["Drops"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            cmdI.Connection.Close();
            con.Dispose();

            //...Return...
            return list;
        }

        public CashierReport GetCashierReport(CashierReportQuery query)
        {
            #region Repositories
            CashierRepository cashierrep = new CashierRepository();
            CashMovementRepository cashmovementrep = new CashMovementRepository();
            ElectronicFundRepository elecrep = new ElectronicFundRepository();
            PickUpRepository pickuprep = new PickUpRepository();
            CashReconciliationRepository cashreconrep = new CashReconciliationRepository();
            InstantMoneyRepository imrep = new InstantMoneyRepository();
            FNBRepository fnbrep = new FNBRepository();
            KwikPayRepository kwikrep = new KwikPayRepository();
            #endregion

            //...Get All Details
            CashierReport report = new CashierReport();

            report.CashierId = query.Cashier;
            report.ReportDate = query.Date;

            report.Cashier = cashierrep.GetCashier(query.Cashier);
            report.CashMovements = cashmovementrep.GetCashMovementsPerEmployee(query.Cashier, query.Date);
            report.ElectronicFunds = elecrep.GetElectronicFundsPerEmployee(query.Cashier, query.Date);
            report.FNB = fnbrep.GetFNBsPerEmployee(query.Cashier, query.Date);
            report.InstantMoney = imrep.GetInstantMoneysPerEmployee(query.Cashier, query.Date);
            report.KwikPays = kwikrep.GetKwikPaysPerEmployee(query.Cashier, query.Date);
            report.Pickups = pickuprep.GetPickUpsPerEmployee(query.Cashier, query.Date);
            report.Recons = cashreconrep.GetCashReconcilationsPerEmployee(query.Cashier, query.Date);

            //...Initialize Totals
            report.CashTotal= 0;
            report.CardsTotal= 0;
            report.ChequeTotal= 0;
            report.SassaTotal= 0;
            report.PickupTotal= 0;
            report.FloatTotal= 0;
            report.ExtraFloatTotal= 0;
            report.SigmaTotal= 0;
            report.IMFloatTotal= 0;
            report.IMRecTotal= 0;
            report.IMPaidTotal= 0;
            report.FNBRefTotal= 0;
            report.FNBRetTotal= 0;
            report.ElecTotal= 0;
            report.AirTotal= 0;
            report.AccTotal= 0;

            //...Get Totals
            foreach(CashMovement item in report.CashMovements)
            {
                report.CashTotal += item.Amount;
            }

            foreach(ElectronicFund item in report.ElectronicFunds)
            {
                switch(item.ElectronicTypeID)
                {
                    case 1: report.SassaTotal += item.Total; break;
                    case 2: report.CardsTotal += item.Total; break;
                    case 3: report.ChequeTotal += item.Total; break;
                }                
            }

            foreach(PickUp item in report.Pickups)
            {
                report.PickupTotal += item.Amount;
                //report.CardsTotal += item.Amount;
            }

            foreach(CashReconciliation item in report.Recons)
            {
                switch (item.ReconciliationTypeID)
                {
                    case 1: report.FloatTotal += item.Amount; break;
                    case 2: report.ExtraFloatTotal += item.Amount; break;
                    case 3: report.SigmaTotal += item.Amount; break;
                } 
            }

            foreach(InstantMoney item in report.InstantMoney)
            {
                switch (item.InstantMoneyTypeID)
                {
                    case 1: report.IMFloatTotal += item.Amount; break;
                    case 2: report.IMRecTotal += item.Amount; break;
                    case 3: report.IMPaidTotal += item.Amount; break;
                } 
            }

            foreach(FNB item in report.FNB)
            {
                switch (item.FNBTypeID)
                {
                    case 1: report.FNBRefTotal += item.Amount; break;
                    case 2: report.FNBRetTotal += item.Amount; break;
                }
            }

            foreach (KwikPay item in report.KwikPays)
            {
                switch (item.KwikPayTypeID)
                {
                    case 1: report.ElecTotal += item.Amount; break;
                    case 2: report.AirTotal += item.Amount; break;
                    case 3: report.AccTotal += item.Amount; break;
                }
            }

            return report;
        }

        public List<SparReconReport> GetSparReconReport(DateTimeFromToQuery query)
        {
            SparReconRepository reconrepo = new SparReconRepository();

            //...Create New Instance of Object...
            List<SparReconReport> list = new List<SparReconReport>();
            SparReconReport ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand();
            cmdI.CommandTimeout = 540;
            cmdI.Connection = con;
            cmdI.CommandText = "f_Admin_Report_SparRecon";
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@SelectedDate", query.From);
            cmdI.Parameters.AddWithValue("@SupplierType", query.IntergerSelect);

            cmdI.Connection.Open();

            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new SparReconReport();
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]).ToShortDateString();
                    ins.GRVExVAT = drI["GRVExVAT"].ToString();
                    ins.GRVInVAT = drI["GRVInVAT"].ToString();
                    ins.GRVInvoiceNumber = drI["GRVInvoiceNumber"].ToString();
                    ins.GRVPayDate = Convert.ToDateTime(drI["GRVPayDate"]).ToShortDateString();
                    ins.GRVPinkSlipNumber = drI["GRVPinkSlipNumber"].ToString();
                    ins.GRVType = drI["GRVType"].ToString();

                    ins.ReconAmount = drI["ReconAmount"].ToString();
                    ins.ReconDate = Convert.ToDateTime(drI["ReconDate"]).ToShortDateString();
                    ins.ReconInvoiceNumber = drI["ReconInvoiceNumber"].ToString();
                    ins.ReconType = drI["ReconType"].ToString();

                    ins.Supplier = drI["Supplier"].ToString();
                    ins.Status = reconrepo.GetReconStatus(Convert.ToDecimal(ins.ReconAmount), Convert.ToInt32(ins.ReconType), ins.ReconInvoiceNumber
                            , Convert.ToDecimal(ins.GRVInVAT), Convert.ToInt32(ins.GRVType), ins.GRVInvoiceNumber);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            cmdI.Connection.Close();
            con.Dispose();

            //...Return...
            return list;
        }

        public CashierDayEndReport GetCashierReport(DateTime ActualDate, int EmployeeId)
        {
            #region Repositories
            CashierRepository cashierrep = new CashierRepository();
            CashMovementRepository cashmovementrep = new CashMovementRepository();
            ElectronicFundRepository elecrep = new ElectronicFundRepository();
            PickUpRepository pickuprep = new PickUpRepository();
            CashReconciliationRepository cashreconrep = new CashReconciliationRepository();
            #endregion

            //...Get All Details
            CashierDayEndReport report = new CashierDayEndReport();
            report.CashierId = EmployeeId;
            report.ReportDate = ActualDate;

            
            report.Cashier = cashierrep.GetCashier(EmployeeId);
            report.CashMovements = cashmovementrep.GetCashMovementsPerEmployeeReport(EmployeeId, ActualDate,1);
            report.ElectronicFunds = elecrep.GetElectronicFundsPerEmployee(EmployeeId, ActualDate);
            report.Pickups = pickuprep.GetPickUpsPerEmployee(EmployeeId, ActualDate,1);
            report.Recons = cashreconrep.GetCashReconcilationsPerEmployee(EmployeeId, ActualDate);

            //...Initialize Totals
            report.CashTotal = 0;
            report.CardsTotal = 0;
            report.ChequeTotal = 0;
            report.SassaTotal = 0;
            report.PickupTotal = 0;
            report.FloatTotal = 0;
            report.ExtraFloatTotal = 0;
            report.SigmaTotal = 0;
            report.CashReconTotal = 0;
            report.EFTReconTotal = 0;
            report.EFTTotal = 0;
            report.EFTFinal = 0;
            report.CashFinal = 0;
            
            //...Get Totals
            foreach (CashMovement item in report.CashMovements)
            {
                report.CashTotal += item.Amount;
            }

            foreach (ElectronicFund item in report.ElectronicFunds)
            {
                switch (item.ElectronicTypeID)
                {
                    case 1: report.SassaTotal += item.Total; break;
                    case 2: report.CardsTotal += item.Total; break;
                    case 3: report.ChequeTotal += item.Total; break;
                }
            }

            foreach (PickUp item in report.Pickups)
            {
                report.PickupTotal += item.Amount;
            }

            foreach (CashReconciliation item in report.Recons)
            {
                switch (item.ReconciliationTypeID)
                {
                    case 1: report.FloatTotal += item.Amount; break;
                    case 2: report.ExtraFloatTotal += item.Amount; break;
                    case 3: report.SigmaTotal += item.Amount; break;
                    case 4: report.CashReconTotal += item.Amount; break;
                    case 5: report.EFTReconTotal += item.Amount; break;
                }
            }

            report.Expected = report.FloatTotal + report.ExtraFloatTotal + report.SigmaTotal  - report.SassaTotal;
            report.Declared = report.PickupTotal + report.CashTotal;
            report.Final = report.Declared - report.Expected;

            report.EFTTotal = report.CardsTotal + report.ChequeTotal;
            report.EFTFinal = report.EFTTotal - report.EFTReconTotal;

            report.CashFinal = report.CashTotal - report.CashReconTotal;

            return report;
        }

        public CashierKwikpayReport GetCashierKwikpayReport(DateTime ActualDate, int EmployeeId)
        {
            #region Repositories
            CashierRepository cashierrep = new CashierRepository();
            CashMovementRepository cashmovementrep = new CashMovementRepository();
            ElectronicFundRepository elecrep = new ElectronicFundRepository();
            PickUpRepository pickuprep = new PickUpRepository();
            CashReconciliationRepository cashreconrep = new CashReconciliationRepository();
            KwikPayRepository KRep = new KwikPayRepository();
            #endregion

            //...Get All Details
            CashierKwikpayReport report = new CashierKwikpayReport();
            report.CashierId = EmployeeId;
            report.ReportDate = ActualDate;


            report.Cashier = cashierrep.GetCashier(EmployeeId);
            report.CashMovements = cashmovementrep.GetCashMovementsPerEmployeeReport(EmployeeId, ActualDate,3);
            report.ElectronicFunds = elecrep.GetElectronicFundsPerEmployee(EmployeeId, ActualDate,3);
            report.Pickups = pickuprep.GetPickUpsPerEmployee(EmployeeId, ActualDate,3);
            report.Recons = cashreconrep.GetCashReconcilationsPerEmployee(EmployeeId, ActualDate);
            report.Kwikpay = KRep.GetKwikPaysPerEmployee(EmployeeId, ActualDate);

            //...Initialize Totals
            report.CashTotal = 0;
            report.CardsTotal = 0;
            report.ChequeTotal = 0;
            report.SassaTotal = 0;
            report.PickupTotal = 0;
            report.FloatTotal = 0;
            report.ExtraFloatTotal = 0;
            report.SigmaTotal = 0;
            report.ElectricityTotal = 0;
            report.AirTimeTotal = 0;
            report.AccountPaymentTotal = 0;
            report.DeclaredTotal = 0;
            report.ExpectedTotal = 0;
            report.Final = 0;

            //...Get Totals
            foreach (CashMovement item in report.CashMovements)
            {
                report.CashTotal += item.Amount;
            }

            foreach (ElectronicFund item in report.ElectronicFunds)
            {
                switch (item.ElectronicTypeID)
                {
                    case 1: report.SassaTotal += item.Total; break;
                    case 2: report.CardsTotal += item.Total; break;
                    case 3: report.ChequeTotal += item.Total; break;
                }
            }

            foreach (PickUp item in report.Pickups)
            {
                report.PickupTotal += item.Amount;
            }

            foreach (CashReconciliation item in report.Recons)
            {
                switch (item.ReconciliationTypeID)
                {
                    case 1: report.FloatTotal += item.Amount; break;
                    case 2: report.ExtraFloatTotal += item.Amount; break;
                    case 3: report.SigmaTotal += item.Amount; break;
                }
            }

            foreach(KwikPay item in report.Kwikpay)
            {
                switch(item.KwikPayTypeID)
                {
                    case 1: report.ElectricityTotal += item.Amount; break;
                    case 2: report.AirTimeTotal += item.Amount; break;
                    case 3: report.AccountPaymentTotal += item.Amount; break;
                }
            }

            report.ExpectedTotal = report.ElectricityTotal + report.AccountPaymentTotal + report.AirTimeTotal;
            report.DeclaredTotal = report.CashTotal + report.CardsTotal + report.PickupTotal + report.ChequeTotal;
            report.Final = report.DeclaredTotal - report.ExpectedTotal;

            return report;
        }
    
        public CashierInstantMoneyReport GetCashierInstantMoneyReport(DateTime ActualDate, int EmployeeId)
        {
            #region Repositories
            CashierRepository cashierrep = new CashierRepository();
            CashMovementRepository cashmovementrep = new CashMovementRepository();
            ElectronicFundRepository elecrep = new ElectronicFundRepository();
            PickUpRepository pickuprep = new PickUpRepository();
            CashReconciliationRepository cashreconrep = new CashReconciliationRepository();
            InstantMoneyRepository IMRep = new InstantMoneyRepository();
            #endregion

            //...Get All Details
            CashierInstantMoneyReport report = new CashierInstantMoneyReport();
            report.CashierId = EmployeeId;
            report.ReportDate = ActualDate;


            report.Cashier = cashierrep.GetCashier(EmployeeId);
            report.CashMovements = cashmovementrep.GetCashMovementsPerEmployeeReport(EmployeeId, ActualDate,4);
            report.ElectronicFunds = elecrep.GetElectronicFundsPerEmployee(EmployeeId, ActualDate,4);
            report.Pickups = pickuprep.GetPickUpsPerEmployee(EmployeeId, ActualDate,4);
            report.Recons = cashreconrep.GetCashReconcilationsPerEmployee(EmployeeId, ActualDate);
            report.IM = IMRep.GetInstantMoneysPerEmployee(EmployeeId, ActualDate);
            //...Initialize Totals
            report.CashTotal = 0;
            report.CardsTotal = 0;
            report.ChequeTotal = 0;
            report.SassaTotal = 0;
            report.PickupTotal = 0;
            report.FloatTotal = 0;
            report.ExtraFloatTotal = 0;
            report.SigmaTotal = 0;

            //...Get Totals
            foreach (CashMovement item in report.CashMovements)
            {
                report.CashTotal += item.Amount;
            }

            foreach (ElectronicFund item in report.ElectronicFunds)
            {
                switch (item.ElectronicTypeID)
                {
                    case 1: report.SassaTotal += item.Total; break;
                    case 2: report.CardsTotal += item.Total; break;
                    case 3: report.ChequeTotal += item.Total; break;
                }
            }

            foreach (PickUp item in report.Pickups)
            {
                report.PickupTotal += item.Amount;
            }

            foreach (CashReconciliation item in report.Recons)
            {
                switch (item.ReconciliationTypeID)
                {                    
                    case 2: report.ExtraFloatTotal += item.Amount; break;
                }
            }
         foreach(InstantMoney item in report.IM)
         {
             switch(item.InstantMoneyTypeID)
             {
                 case 1: report.FloatTotal += item.Amount; break;
                 case 2: report.RecievedTotal += item.Amount; break;
                 case 3: report.PaidTotal += item.Amount; break;
             }
         }

         report.BigFloatTotal = report.FloatTotal + report.ExtraFloatTotal;
         report.ExpectedTotal = report.BigFloatTotal + report.RecievedTotal - report.PaidTotal;
         report.DeclaredTotal = report.CashTotal + report.CardsTotal + report.ChequeTotal + report.PickupTotal;
         report.Final = report.DeclaredTotal - report.ExpectedTotal;

            return report;
        }

        public CashierFNBReport GetCashierFNBReport(DateTime ActualDate, int EmployeeId)
        {
            #region Repositories
            CashierRepository cashierrep = new CashierRepository();
            CashMovementRepository cashmovementrep = new CashMovementRepository();
            ElectronicFundRepository elecrep = new ElectronicFundRepository();
            PickUpRepository pickuprep = new PickUpRepository();
            CashReconciliationRepository cashreconrep = new CashReconciliationRepository();
            FNBRepository FNBRep = new FNBRepository();
            #endregion

            //...Get All Details
            CashierFNBReport report = new CashierFNBReport();
            report.CashierId = EmployeeId;
            report.ReportDate = ActualDate;


            report.Cashier = cashierrep.GetCashier(EmployeeId);
            report.CashMovements = cashmovementrep.GetCashMovementsPerEmployeeReport(EmployeeId, ActualDate, 2);
            report.ElectronicFunds = elecrep.GetElectronicFundsPerEmployee(EmployeeId, ActualDate, 2);
            report.Pickups = pickuprep.GetPickUpsPerEmployee(EmployeeId, ActualDate,2);
            report.Recons = cashreconrep.GetCashReconcilationsPerEmployee(EmployeeId, ActualDate);
            report.FNBs = FNBRep.GetFNBsPerEmployee(EmployeeId, ActualDate);
            //...Initialize Totals
            report.CashTotal = 0;
            report.CardsTotal = 0;
            report.ChequeTotal = 0;
            report.SassaTotal = 0;
            report.PickupTotal = 0;
            report.FloatTotal = 0;
            report.ExtraFloatTotal = 0;
            report.ReferenceTotal = 0;
            report.RefundTotal = 0;
            report.DeclaredTotal = 0;
            report.ExpectedTotal = 0;
            report.Final = 0;

            //...Get Totals
            foreach (CashMovement item in report.CashMovements)
            {
                report.CashTotal += item.Amount;
            }

            foreach (ElectronicFund item in report.ElectronicFunds)
            {
                switch (item.ElectronicTypeID)
                {
                    case 1: report.SassaTotal += item.Total; break;
                    case 2: report.CardsTotal += item.Total; break;
                    case 3: report.ChequeTotal += item.Total; break;
                }
            }

            foreach (PickUp item in report.Pickups)
            {
                report.PickupTotal += item.Amount;
            }

            foreach (CashReconciliation item in report.Recons)
            {
                switch (item.ReconciliationTypeID)
                {
                    case 1: report.FloatTotal += item.Amount; break;
                    case 2: report.ExtraFloatTotal += item.Amount; break;

                }
            }

            foreach (FNB item in report.FNBs)
            {
                switch (item.FNBTypeID)
                {
                    case 1: report.ReferenceTotal += item.Amount; break;
                    case 2: report.RefundTotal += item.Amount; break;
                }
            }

            report.ExpectedTotal = report.ReferenceTotal - report.RefundTotal;
            report.DeclaredTotal = report.CashTotal + report.CardsTotal + report.ChequeTotal + report.PickupTotal;

            report.Final = report.DeclaredTotal - report.ExpectedTotal;

            return report;
        }
    }
}