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
    /// Transit model links to l_Transit. 
    /// Transit table is used to save transit
    /// 
    /// Used by: FK
    /// 
    /// Uses: Sy eie FK
    /// </summary>
    public class Transit
    {
        [DisplayName("Transit ID")]
        [Required(ErrorMessage = "Transit ID is required.")]
        public int TransitID { get; set; }

        [DisplayName("Actual Date")]
        [Required(ErrorMessage = "Actual Date is required.")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

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

        [DisplayName("Transit Type")]
        public string transittype { get; set; }

        [DisplayName("Transit Type")]
        public int TransitTypeID { get; set; }
    }
}