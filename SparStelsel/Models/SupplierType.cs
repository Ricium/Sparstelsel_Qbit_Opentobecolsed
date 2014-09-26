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

    public class SupplierType
    {
        [DisplayName("Supplier Type ID")]
        [Required(ErrorMessage = "Supplier Type ID is required.")]
        public int SupplierTypeID { get; set; }

        [DisplayName("Supplier Type")]
        [Required(ErrorMessage = "Supplier Type is required.")]
        [StringLength(20, ErrorMessage = "Supplier Type may not be longer than 20 characters")]
        public int SupplierType { get; set; }
    }
}