using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{

    public class ElectronicFund
    {
        [DisplayName("Electronic Fund ID")]
        public int ElectronicFundID { get; set; }
        
        [DisplayName("Date")]
        public DateTime ActualDate { get; set; }
        
        [DisplayName("Electronic Fund")]
        public string ElectronicFunds { get; set; }

        [DisplayName("Total")]
        public decimal Total { get; set; }

        [DisplayName("CreatedDate")]
        public DateTime CreatedDate { get; set; }


        [DisplayName("Employee")]
        public string employee { get; set; }
        [DisplayName("Employee")]
        public int EmployeeID { get; set; }

        [DisplayName("Electronic Type")]
        public string electronictype { get; set; }
        public int ElectronicTypeID { get; set; }

        [DisplayName("User ID")]
        public string UserID { get; set; }
        [DisplayName("Company ID")]
        public int CompanyID { get; set; }
        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }
        [DisplayName("Modified By")]
         public string ModifiedBy { get; set; }

        [DisplayName("Removed")]
        public bool Removed { get; set; }

        [DisplayName("Movement Type")]
        public int MovementTypeID { get; set; }
    }
}