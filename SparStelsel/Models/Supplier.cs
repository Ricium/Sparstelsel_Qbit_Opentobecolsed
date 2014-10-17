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

        [DisplayName("Supplier")]
        [Required(ErrorMessage = "Supplier is required.")]
        [StringLength(20, ErrorMessage = "Supplier may not be longer than 20 characters")]
        public int Suppliers { get; set; }

        [DisplayName("Stock Condition")]
        [Required(ErrorMessage = "Stock Condition is required.")]
        [StringLength(50, ErrorMessage = "Stock Condition may not be longer than 50 characters")]
        public int StockCondition { get; set; }

        [DisplayName("Term")]
        [Required(ErrorMessage = "Term is required.")]
        [StringLength(50, ErrorMessage = "Term may not be longer than 50 characters")]
        public int Term { get; set; }

        [DisplayName("Supplier Type ID")]
        [Required(ErrorMessage = "Supplier Type ID is required.")]
        public int SupplierTypeID { get; set; }

        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product ID is required.")]
        public int ProductID { get; set; }
    }
}