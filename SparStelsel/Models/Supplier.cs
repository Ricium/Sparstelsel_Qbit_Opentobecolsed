using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    /// <summary>
    /// 
    /// 
    /// 
    /// 
    /// 
    ///
    /// </summary>

    public class Supplier
    {
        [DisplayName("Supplier ID")]
        public int SupplierID { get; set; }

        [DisplayName("Suppliers")]
        [Required(ErrorMessage = "Suppliers is required.")]
        [StringLength(50, ErrorMessage = "Supplier may not be longer than 50 characters")]
        public string Suppliers { get; set; }

        [DisplayName("Stock Condition")]
        [Required(ErrorMessage = "Stock Condition is required.")]
        [StringLength(50, ErrorMessage = "Stock Condition may not be longer than 50 characters")]
        public string StockCondition { get; set; }

        [DisplayName("Term")]
        [Required(ErrorMessage = "Term is required.")]
        [StringLength(50, ErrorMessage = "Term may not be longer than 50 characters")]
        public string Term { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Supplier Type ID")]
        [Required(ErrorMessage = "Supplier Type ID is required.")]
        public string suppliertypeid2 { get; set; }
        public int SupplierTypeID { get; set; }

        [DisplayName("Paydate from Friday")]
        public bool FromFriday { get; set; }
       

        [DisplayName("Company ID")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }


        [DisplayName("Modified By")]
        public int ModifiedBy { get; set; }

        [DisplayName("Removed")]
        public bool Removed { get; set; }
    }
}