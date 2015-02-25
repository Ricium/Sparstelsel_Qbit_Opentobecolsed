using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class SparInvoiceRecon
    {
        public int SparReconId { get; set; }
        public DateTime GRVDate { get; set; }
        public int SupplierId { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CompanyId { get; set; }
        public bool Removed { get; set; }
        public int GRVTypeId { get; set; }
        public string Status { get; set; }
    }
}