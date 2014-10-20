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

    public class ReconcilationType
    {
        [DisplayName("Reconcilation Type ID")]
        [Required(ErrorMessage = "Reconcilation Type ID is required.")]
        public int ReconcilationTypeID { get; set; }

        [DisplayName("Actual Date")]
        [Required(ErrorMessage = "Actual Date is required.")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Cash Reconcilation ID")]
        [Required(ErrorMessage = "Proof Of Payment ID is required.")]
        public int CashReconcilationID { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "User ID is required.")]
        public int UserID { get; set; }

        [DisplayName("User Type ID")]
        [Required(ErrorMessage = "User Type ID is required.")]
        public int UserTypeID { get; set; }
    }
}