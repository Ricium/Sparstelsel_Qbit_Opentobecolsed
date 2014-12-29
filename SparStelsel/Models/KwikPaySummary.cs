using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace SparStelsel.Models
{
    public class KwikPaySummary
    {
        public DateTime SummaryDate { get; set; }
        public string UserID { get; set; }
        public string user { get; set; }
        public decimal Total { get; set; }
    }
}