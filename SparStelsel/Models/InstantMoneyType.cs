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

    public class InstantMoneyType
    {
        [DisplayName("Instant Money Type ID")]
        [Required(ErrorMessage = "Instant Money Type ID is required.")]
        public int InstantMoneyTypeID { get; set; }

        [DisplayName("Instant Money Type")]
        [Required(ErrorMessage = "Instant Money Type is required.")]
        [StringLength(20, ErrorMessage = "Instant Money Type may not be longer than 20 characters")]
        public int InstantMoneyType { get; set; }
    }
}