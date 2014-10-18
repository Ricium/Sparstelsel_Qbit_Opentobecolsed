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

        [DisplayName("User Type")]
        [Required(ErrorMessage = "User Type is required.")]
        [StringLength(20, ErrorMessage = "User Type may not be longer than 20 characters")]
        public string ElectronicTypes { get; set; }

    }
}

