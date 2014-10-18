using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{

    public class Comment
    {
        [DisplayName("Comment ID")]
        [Required(ErrorMessage = "Comment ID is required.")]
        public int CommentID { get; set; }

        [DisplayName("Comment")]
        [Required(ErrorMessage = "Comment.")]
        public string Comments { get; set; }

        [DisplayName("Comment Type ID")]
        [Required(ErrorMessage = "Comment Type ID is required.")]
        public int CommentTypeID { get; set; }
    }
}