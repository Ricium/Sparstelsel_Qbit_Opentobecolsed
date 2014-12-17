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

    public class ReconciliationType
    {
        [DisplayName("Reconciliation Type ID")]
        [Required(ErrorMessage = "Reconciliation Type ID is required.")]
        public int ReconciliationTypeID { get; set; }

        [DisplayName("Actual Date")]
        [Required(ErrorMessage = "Actual Date is required.")]
        public DateTime ActualDate { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "User ID is required.")]
        public int UserID { get; set; }

        [DisplayName("Company ID")]
        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyID { get; set; }

        [DisplayName("ModifiedDate")]
        [Required(ErrorMessage = "ModifiedDate is required.")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("ModifiedBy")]
        [Required(ErrorMessage = "ModifiedBy is required.")]
          public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        [Required(ErrorMessage = "Removed is required.")]
        public bool Removed { get; set; }
    }
}