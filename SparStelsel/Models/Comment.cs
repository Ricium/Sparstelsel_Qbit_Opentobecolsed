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

        [DisplayName("CreatedDate")]
        [Required(ErrorMessage = "CreatedDate.")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Comment Type ID")]
        [Required(ErrorMessage = "Comment Type ID is required.")]
        public string commenttype { get; set; }
        public int CommentTypeID { get; set; }

        [DisplayName("Company ID")]
        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        [Required(ErrorMessage = "Modified Date is required.")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
        [Required(ErrorMessage = "Modified By is required.")]
          public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        [Required(ErrorMessage = "Removed is required.")]
        public bool Removed { get; set; }
    }
}