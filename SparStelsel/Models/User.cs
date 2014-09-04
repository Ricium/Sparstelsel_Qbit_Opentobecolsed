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

    public class User
    {
        [DisplayName("User ID")]
        [Required(ErrorMessage = "User ID is required.")]
        public int UserID { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name is required.")]
        [StringLength(20, ErrorMessage = "User Name may not be longer than 20 characters")]
        public int UserName { get; set; }

        [DisplayName("User Surname")]
        [Required(ErrorMessage = "User Surname is required.")]
        [StringLength(20, ErrorMessage = "User Surname may not be longer than 20 characters")]
        public int UserSurname { get; set; }

        [DisplayName("ID")]
        [Required(ErrorMessage = "ID is required.")]
        [StringLength(20, ErrorMessage = "ID may not be longer than 20 characters")]
        public int ID { get; set; }

        [DisplayName("UserCell")]
        [Required(ErrorMessage = "UserCell is required.")]
        [StringLength(20, ErrorMessage = "UserCell may not be longer than 20 characters")]
        public int UserCell { get; set; }

        [DisplayName("UserEmail")]
        [Required(ErrorMessage = "UserEmail is required.")]
        [StringLength(20, ErrorMessage = "UserEmail may not be longer than 20 characters")]
        public int UserEmail { get; set; }

        [DisplayName("User Type ID")]
        [Required(ErrorMessage = "User Type ID is required.")]
        public int UserTypeID { get; set; }
    }
}