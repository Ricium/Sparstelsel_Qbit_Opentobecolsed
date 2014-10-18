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

    public class MovementType
    {
        [DisplayName("Movement Type ID")]
        [Required(ErrorMessage = "Movement Type ID is required.")]
        public int MovementTypeID { get; set; }

        [DisplayName("Movement Type")]
        [Required(ErrorMessage = "Movement Type is required.")]
        [StringLength(20, ErrorMessage = "Movement Type may not be longer than 20 characters")]
        public string MovementTypes { get; set; }
    }
}