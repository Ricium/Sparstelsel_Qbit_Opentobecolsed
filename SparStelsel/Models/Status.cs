using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{

    public class Status
    {
        [DisplayName("Status ID")]
        [Required(ErrorMessage = "Status ID is required.")]
        public int StatusID { get; set; }

        [DisplayName("Status Name")]
        [Required(ErrorMessage = "Status Name is required.")]
        public string StatusName { get; set; }

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