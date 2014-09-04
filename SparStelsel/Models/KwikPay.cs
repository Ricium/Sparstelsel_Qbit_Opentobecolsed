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

    public class KwikPay
    {
        [DisplayName("Kwik Pay ID")]
        [Required(ErrorMessage = "Kwik Pay ID is required.")]
        public int KwikPayID { get; set; }

        [DisplayName("Actual Date")]
        [Required(ErrorMessage = "Actual Date is required.")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("Kwik Pay Type ID")]
        [Required(ErrorMessage = "Kwik Pay Type ID is required.")]
        public int KwikPayTypeID { get; set; }

        [DisplayName("Employee ID")]
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }

        [DisplayName("Employee Type ID")]
        [Required(ErrorMessage = "Employee Type ID is required.")]
        public int EmployeeTypeID { get; set; }
    }
}