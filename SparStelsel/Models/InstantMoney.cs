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

    public class InstantMoney
    {
        [DisplayName("Instant Money ID")]
        [Required(ErrorMessage = "Instant Money ID is required.")]
        public int InstantMoneyID { get; set; }

        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Instant Money Type")]
        public string instantmoneytype { get; set; }
        public int InstantMoneyTypeID { get; set; }

        [DisplayName("User ID")]
        public string UserID { get; set; }

        [DisplayName("Company ID")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
          public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        public bool Removed { get; set; }

        [DisplayName("Employee")]
        public string EmployeeID { get; set; }
    }
}