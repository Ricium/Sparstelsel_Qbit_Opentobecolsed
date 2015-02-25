using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{

    public class MoneyUnit
    {
        [DisplayName("Money Unit ID")]
        [Required(ErrorMessage = "Money Unit ID is required.")]
        public int MoneyUnitID { get; set; }

        [DisplayName("Money Units")]
        [Required(ErrorMessage = "Money Units is required.")]
        [StringLength(20, ErrorMessage = "Money Unit may not be longer than 20 characters")]
        public string MoneyUnits { get; set; }

        [DisplayName("Company ID")]
        public int CompanyID { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Modified By")]
          public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        public bool Removed { get; set; }
    }
}