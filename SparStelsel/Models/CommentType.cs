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

    public class CommentType
    {
        [DisplayName("Comment Type ID")]
        [Required(ErrorMessage = "Comment Type ID is required.")]
        public int CommentTypeID { get; set; }

        [DisplayName("Comment Type")]
        [Required(ErrorMessage = "Comment Type is required.")]
        [StringLength(20, ErrorMessage = "Comment Type may not be longer than 20 characters")]
        public int CommentType { get; set; }
    }
}