using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class CashMovement
    {
        [DisplayName("Cash Movement ID")]
        [Required(ErrorMessage = "Cash Movement ID is required.")]
        public int CashMovementID { get; set; }

        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Amount")]
        public decimal Amount { get; set; }

        [DisplayName("Cash Type ID")]
        public string movementtype { get; set; }
        public int MovementTypeID { get; set; }

        [DisplayName("Money Unit")]
        public string moneyunit { get; set; }
        public int MoneyUnitID { get; set; }


        [DisplayName("Employee")]
        public string employee { get; set; }
        [DisplayName("Employee")]
        public int EmployeeID { get; set; }

        [DisplayName("Modified By")]
        public string ModifiedBy { get; set; }

        public int Count { get; set; }

        /*[DisplayName("User ID")]
        public string UserID { get; set; }

        [DisplayName("User Type ID")]
        public int UserTypeID { get; set; }*/
    }

    public class CashMovementMultiple
    {
        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Employee")]
        public int EmployeeID { get; set; }

        [DisplayName("Movement Type")]
        public int MovementTypeID { get; set; }

        public List<CashMovement> Movements { get; set; }
    }
}