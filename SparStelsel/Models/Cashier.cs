using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace SparStelsel.Models
{
    public class Cashier
    {
        [DisplayName("Cashier ID")]
        [Required(ErrorMessage = "Cashier ID is required.")]
        public int CashierID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int CompanyID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool Removed { get; set; }
        
    }
}