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

    public class CashReconciliation
    {
        [DisplayName("Cash Reconciliation ID")]
        public int CashReconciliationID { get; set; }

        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Reconciliation Type")]
        public string recontype { get; set; }
        public int ReconciliationTypeID { get; set; }


        [DisplayName("User ID")]
        public string UserID { get; set; }

        [DisplayName("Company ID")]
        public int CompanyID { get; set; }

        [DisplayName("Employee")]
        public string employee { get; set; }
        public int EmployeeID { get; set; }


        [DisplayName("Movement Type")]
        public string movementtype { get; set; }
        public int MovementTypeID { get; set; }

        [DisplayName("Amount")]
        public decimal Amount { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
          public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        public bool Removed { get; set; }
    }
}