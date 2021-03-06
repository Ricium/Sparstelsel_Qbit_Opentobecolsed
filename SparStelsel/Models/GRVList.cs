﻿using System;
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

        [DisplayName("Expected Pay Date")]
        public DateTime ExpectedPayDate { get; set; }


        [DisplayName("Invoice Date")]
        [Required(ErrorMessage = "Invoice Date is required.")]
        public DateTime InvoiceDate { get; set; }

        [DisplayName("Excluding Vat")]
        [Required(ErrorMessage = "Excluding Vat is required.")]
        public decimal ExcludingVat { get; set; }

        [DisplayName("Including Vat")]
        [Required(ErrorMessage = "Including Vat is required.")]
        public decimal IncludingVat { get; set; }

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("GRV Type ID")]
        [Required(ErrorMessage = "GRV Type ID is required.")]
        public int GRVTypeID { get; set; }

        [DisplayName("Supplier ID")]
        [Required(ErrorMessage = "Supplier ID is required.")]
        public int SupplierID { get; set; }

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

        public int BatchId { get; set; }
        public bool hasError { get; set; }

        public string SupplierDetails { get; set; }
    }

    public class GRVImport
    {
        public int BatchId { get; set; }
        public string FileName { get; set; }
        public DateTime ModifiedDate { get; set; }
          public string ModifiedBy { get; set; }
    }

    public class GRVListImport
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

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("GRV Type ID")]
        [Required(ErrorMessage = "GRV Type ID is required.")]
        public int GRVTypeID { get; set; }

        [DisplayName("Supplier ID")]
        [Required(ErrorMessage = "Supplier ID is required.")]
        public int SupplierID { get; set; }

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

        public int BatchId { get; set; }
        public bool hasError { get; set; }
        public string SupplierDetails { get; set; }


        public string Suppliers { get; set; }
        public string StockCondition { get; set; }
        public string Term { get; set; }
        public int SupplierTypeID { get; set; }
        public bool FromFriday { get; set; }
    }

    public class GRVExcel
    {
        public string InvNo { get; set; }
        public string REF { get; set; }
        public string Typ  { get; set; }
        public int Number { get; set; }
        public int Seq { get; set; }
        public string GRVBook { get; set; }
        public string GRVDate { get; set; }
        public string InvDate { get; set; }
        public string SupplierName { get; set; }
        public string ExclVAT { get; set; }
        public string VAT { get; set; }
        public string InclVAT  { get; set; }

    }
}