using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class Cash
    {
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }
        [DisplayName("Total Declared")]
        public decimal TotalDeclared { get; set; }
        [DisplayName("Date")]
        public DateTime Date { get; set; }
        [DisplayName("Total Expected")]
        public decimal TotalExpected { get; set; }
        [DisplayName("Cash Expected")]
        public decimal CashExpected { get; set; }
        [DisplayName("Cash Over")]
        public decimal CashOver { get; set; }
        [DisplayName("Movement Type")]
        public string MovementType { get; set; }
    }
}