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

    public class UserType
    {
        [DisplayName("User Type ID")]
        [Required(ErrorMessage = "User Type ID is required.")]
        public int UserTypeID { get; set; }

        [DisplayName("User Type")]
        [Required(ErrorMessage = "User Type is required.")]
        [StringLength(20, ErrorMessage = "User Type may not be longer than 20 characters")]
        public int UserType { get; set; }
    }
}