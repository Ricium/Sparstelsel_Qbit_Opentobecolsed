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
        public string electronicfund { get; set; }
        public int ElectronicTypeID { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "User ID is required.")]
        public int UserID { get; set; }

        [DisplayName("User Type ID")]
        [Required(ErrorMessage = "User Type ID is required.")]
        public int UserTypeID { get; set; }
    }
}