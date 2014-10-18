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

    public class ElectronicFund
    {
        [DisplayName("Electronic Fund ID")]
        [Required(ErrorMessage = "Electronic Fund ID is required.")]
        public int ElectronicFundID { get; set; }

        [DisplayName("Electronic Fund")]
        [Required(ErrorMessage = "Electronic Fund is required.")]
        [StringLength(20, ErrorMessage = "Electronic Fund may not be longer than 20 characters")]
        public string ElectronicFunds { get; set; }

        [DisplayName("Total")]
        [Required(ErrorMessage = "Total is required.")]
        public decimal Total { get; set; }

        [DisplayName("Electronic Type ID")]
        [Required(ErrorMessage = "Electronic Type ID is required.")]
        public int ElectronicTypeID { get; set; }

        [DisplayName("Employee ID")]
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }

        [DisplayName("Employee Type ID")]
        [Required(ErrorMessage = "Employee Type ID is required.")]
        public int EmployeeTypeID { get; set; }
    }
}