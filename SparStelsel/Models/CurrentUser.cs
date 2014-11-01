using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class CurrentUser
    {
        public int UserID { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}