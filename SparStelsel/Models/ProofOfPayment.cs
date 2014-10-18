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

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Payment Description")]
        [Required(ErrorMessage = "Payment Description is required.")]
        [StringLength(50, ErrorMessage = "Payment Description may not be longer than 50 characters")]
        public string PaymentDescription { get; set; }

        [DisplayName("Supplier ID")]
        [Required(ErrorMessage = "Supplier ID is required.")]
        public int SupplierID { get; set; }

        [DisplayName("Supplier Type ID")]
        [Required(ErrorMessage = "Supplier Type ID is required.")]
        public int SupplierTypeID { get; set; }
    }
}