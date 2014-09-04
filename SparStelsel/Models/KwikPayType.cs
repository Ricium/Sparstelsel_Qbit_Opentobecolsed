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
        public int KwikPayType { get; set; }
    }
}