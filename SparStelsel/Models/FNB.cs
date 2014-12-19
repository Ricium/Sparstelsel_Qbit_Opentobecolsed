using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{


    public class FNB
    {
        [DisplayName("FNB ID")]
        [Required(ErrorMessage = "FNB ID is required.")]
        public int FNBID { get; set; }

        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("FNB Type")]
        public string fnbtype { get; set; }
        public int FNBTypeID { get; set; }

        [DisplayName("User")]
        public int UserID { get; set; }

        [DisplayName("Company ID")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
          public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        public bool Removed { get; set; }
    }
}