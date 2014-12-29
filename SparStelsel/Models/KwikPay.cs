using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{

    public class KwikPay
    {
        [DisplayName("Kwik Pay ID")]
        [Required(ErrorMessage = "Kwik Pay ID is required.")]
        public int KwikPayID { get; set; }

        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Kwik Pay Type")]
        public int KwikPayTypeID { get; set; }
        [DisplayName("Kwik Pay Type")]
        public string kwikpaytype{ get; set; }

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