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

    public class PickUp
    {
        [DisplayName("Pick Up ID")]
        [Required(ErrorMessage = "Pick Up ID is required.")]
        public int PickUpID { get; set; }

        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Amount")]
        public decimal Amount { get; set; }

        [DisplayName("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Employee")]
        public string employee { get; set; }
        [DisplayName("Employee")]
        public int EmployeeID { get; set; }

        [DisplayName("Movement Type ")]
        public string movementtype { get; set; }
        public int MovementTypeID  { get; set; }

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
    }
}