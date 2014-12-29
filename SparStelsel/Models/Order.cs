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

    public class Order
    {
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required.")]
        public int OrderID { get; set; }

        [DisplayName("Order Date")]
        [Required(ErrorMessage = "Order Date is required.")]
        public DateTime OrderDate { get; set; }

        [DisplayName("Expected Delivery Date")]
        public DateTime ExpectedDeliveryDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Supplier")]
        [Required(ErrorMessage = "Supplier ID is required.")]
        public string supplier { get; set; }
        public int SupplierID { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "User ID is required.")]
        public string UserID { get; set; }

        [DisplayName("Comment ID")]
        [Required(ErrorMessage = "Comment ID is required.")]
        public int CommentID { get; set; }

        [DisplayName("Company ID")]
        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        [Required(ErrorMessage = "Modified Date is required.")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
        [Required(ErrorMessage = "Modified By is required.")]
          public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        [Required(ErrorMessage = "Removed is required.")]
        public bool Removed { get; set; }

        [DisplayName("Pink Slip Number")]
        [Required(ErrorMessage = "Pink Slip Number is required.")]
        public string PinkSlipNumber { get; set; }

        [DisplayName("Suffix")]
        public string Suffix { get; set; }

        public string ordercomment { get; set; }
    }
}