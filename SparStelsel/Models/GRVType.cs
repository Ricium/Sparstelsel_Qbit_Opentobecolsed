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

    public class GRVType
    {
        [DisplayName("GRV Type ID")]
        [Required(ErrorMessage = "GRV Type ID is required.")]
        public int GRVTypeID { get; set; }

        [DisplayName("GRV Type")]
        [Required(ErrorMessage = "GRV Type is required.")]
        [StringLength(20, ErrorMessage = "GRV Type may not be longer than 20 characters")]
        public string GRVTypes { get; set; }
    }
}