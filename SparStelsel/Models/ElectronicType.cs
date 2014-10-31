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
    
    public class ElectronicType 
    {
        [DisplayName("Electronic Type ID")]
        [Required(ErrorMessage = "Electronic Type ID is required.")]
        public int ElectronicTypeID { get; set; }

        [DisplayName("Electronic Types")]
        [Required(ErrorMessage = "Electronic Types is required.")]
        [StringLength(20, ErrorMessage = "Electronic Types may not be longer than 20 characters")]
        public string ElectronicTypes { get; set; }

        [DisplayName("Electronic Type Description")]
        [Required(ErrorMessage = "Electronic Type Description is required.")]
        public string ElectronicTypeDescription { get; set; }

        [DisplayName("Company ID")]
        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        [Required(ErrorMessage = "Modified Date is required.")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
        [Required(ErrorMessage = "Modified By is required.")]
        public int ModifiedBy { get; set; }

        [DisplayName("Removed")]
        [Required(ErrorMessage = "Removed is required.")]
        public bool Removed { get; set; }

    }
}

