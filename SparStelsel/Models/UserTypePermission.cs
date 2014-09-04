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

    public class UserTypePermission
    {
        [DisplayName("User Type Permission ID")]
        [Required(ErrorMessage = "User Type Permission ID is required.")]
        public int UserTypePermissionID { get; set; }

        [DisplayName("Permission")]
        [Required(ErrorMessage = "Permission is required.")]
        [StringLength(20, ErrorMessage = "Permission may not be longer than 20 characters")]
        public int Permission { get; set; }

        [DisplayName("User Type ID")]
        [Required(ErrorMessage = "User Type ID is required.")]
        public int UserTypeID { get; set; }
    }
}