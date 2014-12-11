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