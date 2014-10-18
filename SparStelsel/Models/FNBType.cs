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

    public class FNBType
    {
        [DisplayName("FNB Type ID")]
        [Required(ErrorMessage = "FNB Type ID is required.")]
        public int FNBTypeID { get; set; }

        [DisplayName("FNB Type")]
        [Required(ErrorMessage = "FNB Type is required.")]
        [StringLength(20, ErrorMessage = "FNB Type may not be longer than 20 characters")]
        public string FNBTypes { get; set; }

    }
}

