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

    public class MoneyUnit
    {
        [DisplayName("Money Unit ID")]
        [Required(ErrorMessage = "Money Unit ID is required.")]
        public int MoneyUnitID { get; set; }

        [DisplayName("Money Unit")]
        [Required(ErrorMessage = "Money Unit is required.")]
        [StringLength(20, ErrorMessage = "Money Unit may not be longer than 20 characters")]
        public int MoneyUnit { get; set; }
    }
}