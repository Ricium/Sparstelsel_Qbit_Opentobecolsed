using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{


    public class CoinMovement
    {
        [DisplayName("Coin Movement ID")]
        [Required(ErrorMessage = "Coin Movement ID is required.")]
        public int CoinMovementID { get; set; }

        [DisplayName("Actual Date")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Amount")]
        public decimal Amount { get; set; }

        [DisplayName("Movement Type")]
        
        public string movementtype { get; set; }
        [DisplayName("Movement Type")]
        public int MovementTypeID { get; set; }

        [DisplayName("Money Unit")]
        public string moneyunit { get; set; }
        public int MoneyUnitID { get; set; }

        [DisplayName("User ID")]
        public string UserID { get; set; }

        [DisplayName("User Type ID")]
        public int UserTypeID { get; set; }
    }
}