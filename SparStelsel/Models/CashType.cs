using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{


    public class CashType
    {
        [DisplayName("Cash Type ID")]
        [Required(ErrorMessage = "Cash Type ID is required.")]
        public int CashTypeID { get; set; }

        [DisplayName("Cash Type")]
        [Required(ErrorMessage = "Cash Type is required.")]
        [StringLength(20, ErrorMessage = "Cash Type may not be longer than 20 characters")]
        public int CashTypes { get; set; }
    }
}