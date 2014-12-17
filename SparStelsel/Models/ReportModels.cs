using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class YearMonthQuery
    {
        public int Month { get; set; }
        public int Year { get; set; }
    }

    public class DateTimeFromToQuery
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }

    public class OrdervsGRVReport
    {
        public string Day { get; set; }
        public string Date { get; set; }
        public string OrderTotal { get; set; }
        public string FridayOrderTotal { get; set; }
        public string GRVTotal { get; set; }
        public string FridayGRVTotal { get; set; }
    }
}