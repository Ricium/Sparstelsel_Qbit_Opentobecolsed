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

    public class InstantMoneyType
    {
        [DisplayName("Instant Money Type ID")]
        [Required(ErrorMessage = "Instant Money Type ID is required.")]
        public int InstantMoneyTypeID { get; set; }

        [DisplayName("Instant Money Type")]
        [Required(ErrorMessage = "Instant Money Type is required.")]
        [StringLength(20, ErrorMessage = "Instant Money Type may not be longer than 20 characters")]
        public string InstantMoneyTypes { get; set; }

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
    }
}