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

    public class ProofOfPayment
    {
        [DisplayName("Proof Of Payment ID")]
        [Required(ErrorMessage = "Proof Of Payment ID is required.")]
        public int ProofOfPaymentID { get; set; }

        [DisplayName("Actual Date")]
        [Required(ErrorMessage = "Actual Date is required.")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Payment Description")]
       // [Required(ErrorMessage = "Payment Description is required.")]
        [StringLength(50, ErrorMessage = "Payment Description may not be longer than 50 characters")]
        public string PaymentDescription { get; set; }

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Amount Paid")]
        [Required(ErrorMessage = "Amount Paid is required.")]
        public decimal Amount { get; set; }

        [DisplayName("Company ID")]
        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
        public string ModifiedBy { get; set; }

        [DisplayName("Removed")]    
        public bool Removed { get; set; }

        [DisplayName("Invoice Number")]
        public string InvoiceNumber { get; set; }

        [DisplayName("CashType")]
        public int CashTypeID { get; set; }

        [DisplayName("CashType")]
        public string cashtype { get; set; }

        [DisplayName("Supplier")]
        public string SupplierID { get; set; }
    }
}