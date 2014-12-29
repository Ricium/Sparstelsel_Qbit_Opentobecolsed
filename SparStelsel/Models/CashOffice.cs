using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class CashOffice
    {
        public int CashOfficeID { get; set; }
        public int CashOfficeTypeID { get; set; }
        public string cashofficetype { get; set; }
        public int MoneyUnitTypeID { get; set; }
        public string moneyunit { get; set; }
        public decimal Amount { get; set; }
        public int CashStatus { get; set; }
        public string cashstatusindex { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime ActualDate { get; set; }
        public bool Removed { get; set; }
        public int CompanyID { get; set; }
    }
}