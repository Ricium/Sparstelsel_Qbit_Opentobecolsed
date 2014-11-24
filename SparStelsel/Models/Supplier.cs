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
        [Required(ErrorMessage = "Supplier ID is required.")]
        public int SupplierID { get; set; }

        [DisplayName("Suppliers")]
        [Required(ErrorMessage = "Suppliers is required.")]
        [StringLength(20, ErrorMessage = "Supplier may not be longer than 20 characters")]
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
        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Supplier Type ID")]
        [Required(ErrorMessage = "Supplier Type ID is required.")]
        public string suppliertypeid { get; set; }
        public int SupplierTypeID { get; set; }

       

        [DisplayName("Company ID")]
        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        [Required(ErrorMessage = "Modified Date is required.")]
        public DateTime ModifiedDate { get; set; }


        [DisplayName("Modified By")]
        [Required(ErrorMessage = "Modified By is required.")]
        public int ModifiedBy { get; set; }

        [DisplayName("Removed")]
        [Required(ErrorMessage = "Removed is required.")]
        public bool Removed { get; set; }
    }
}