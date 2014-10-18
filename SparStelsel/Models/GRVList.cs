using System;
using System.Collections.Generic;
using System.Linq;
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

    public class GRVList
    {
        [DisplayName("GRV List ID")]
        [Required(ErrorMessage = "GRV List ID is required.")]
        public int GRVListID { get; set; }

        [DisplayName("Invoice Number")]
        [Required(ErrorMessage = "Invoice Number is required.")]
        public string InvoiceNumber { get; set; }

        [DisplayName("State Date")]
        [Required(ErrorMessage = "State Date is required.")]
        public DateTime StateDate { get; set; }

        [DisplayName("Number")]
        [Required(ErrorMessage = "Number is required.")]
        public int Number { get; set; }

        [DisplayName("Pay Date")]
        [Required(ErrorMessage = "Pay Date is required.")]
        public DateTime PayDate { get; set; }

        [DisplayName("Pink Slip Number")]
        [Required(ErrorMessage = "Pink Slip Number is required.")]
        [StringLength(20, ErrorMessage = "Pink Slip Number may not be longer than 20 characters")]
        public string PinkSlipNumber { get; set; }

        [DisplayName("GRV Date")]
        [Required(ErrorMessage = "GRV Date is required.")]
        public DateTime GRVDate { get; set; }

        [DisplayName("Invoice Date")]
        [Required(ErrorMessage = "Invoice Date is required.")]
        public DateTime InvoiceDate { get; set; }

        [DisplayName("Excluding Vat")]
        [Required(ErrorMessage = "Excluding Vat is required.")]
        public decimal ExcludingVat { get; set; }

        [DisplayName("Including Vat")]
        [Required(ErrorMessage = "Including Vat is required.")]
        public decimal IncludingVat { get; set; }

        [DisplayName("GRV Type ID")]
        [Required(ErrorMessage = "GRV Type ID is required.")]
        public int GRVTypeID { get; set; }

        [DisplayName("Supplier ID")]
        [Required(ErrorMessage = "Supplier ID is required.")]
        public int SupplierID { get; set; }

        [DisplayName("Supplier Type ID")]
        [Required(ErrorMessage = "Supplier Type ID is required.")]
        public int SupplierTypeID { get; set; }
    }
}