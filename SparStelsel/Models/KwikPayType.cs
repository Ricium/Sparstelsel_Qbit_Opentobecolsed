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

    public class KwikPayType
    {
        [DisplayName("Kwik Pay Type ID")]
        [Required(ErrorMessage = "Kwik Pay Type ID is required.")]
        public int KwikPayTypeID { get; set; }

        [DisplayName("Kwik Pay Type")]
        [Required(ErrorMessage = "Kwik Pay Type is required.")]
        [StringLength(20, ErrorMessage = "Kwik Pay Type may not be longer than 20 characters")]
        public string KwikPayTypes { get; set; }

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