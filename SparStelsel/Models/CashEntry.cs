using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class CashEntry
    {
        public int R200 { get; set; }
        public int R100 { get; set; }
        public int R50 { get; set; }
        public int R20 { get; set; }
        public int R10 { get; set; }
        public int R5 { get; set; }
        public int R2 { get; set; }
        public int R1{ get; set; }
        public int R050 { get; set; }
        public int R020 { get; set; }
        public int R010 { get; set; }
        public string UserID { get; set; }
        public DateTime CurrentDate { get; set; }
        public int CashTypeID { get; set; }
    }
}