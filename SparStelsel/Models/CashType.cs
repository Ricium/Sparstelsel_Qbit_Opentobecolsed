using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{


    public class CashType
    {
        [DisplayName("Cash Type ID")]
        [Required(ErrorMessage = "Cash Type ID is required.")]
        public int CashTypeID { get; set; }

        [DisplayName("Cash Type")]
        [Required(ErrorMessage = "Cash Type is required.")]
        [StringLength(20, ErrorMessage = "Cash Type may not be longer than 20 characters")]
        public string CashTypes { get; set; }

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