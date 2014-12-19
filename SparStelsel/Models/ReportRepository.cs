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

            //...SQL Commands...
            cmdI = new SqlCommand("Select g.InvoiceNumber, g.PinkSlipNumber, g.ExpectedPayDate, g.PayDate, g.InvoiceDate, g.StateDate "
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
                    + "	and g.SupplierID LIKE '%" + query.Supplier + "'", con);
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
    }
}