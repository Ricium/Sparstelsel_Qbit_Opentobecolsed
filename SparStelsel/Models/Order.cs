﻿using System;
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

    public class Order
    {
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required.")]
        public int OrderID { get; set; }

        [DisplayName("Order Date")]
        [Required(ErrorMessage = "Order Date is required.")]
        public DateTime OrderDate { get; set; }

        [DisplayName("Exspected Delivery Date")]
        public DateTime ExspectedDeliveryDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("Supplier ID")]
        [Required(ErrorMessage = "Supplier ID is required.")]
        public int SupplierID { get; set; }

        [DisplayName("Supplier Type ID")]
        [Required(ErrorMessage = "Supplier Type ID is required.")]
        public int SupplierTypeID { get; set; }

        [DisplayName("Employee ID")]
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }

        [DisplayName("Employee Type ID")]
        [Required(ErrorMessage = "Employee Type ID is required.")]
        public int EmployeeTypeID { get; set; }

        [DisplayName("Comment ID")]
        [Required(ErrorMessage = "Comment ID is required.")]
        public int CommentID { get; set; }
    }
}