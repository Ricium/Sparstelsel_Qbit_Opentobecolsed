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

    public class CoinMovement
    {
        [DisplayName("Coin Movement ID")]
        [Required(ErrorMessage = "Coin Movement ID is required.")]
        public int CoinMovementID { get; set; }

        [DisplayName("Actual Date")]
        [Required(ErrorMessage = "Actual Date is required.")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }

        [DisplayName("Movement Type")]
        
        public string movementtype { get; set; }
        [DisplayName("Movement Type")]
        [Required(ErrorMessage = "Movement Type ID is required.")]
        public int MovementTypeID { get; set; }

        [DisplayName("Money Unit")]
        [Required(ErrorMessage = "Money Unit ID is required.")]
        public string moneyunit { get; set; }
        public int MoneyUnitID { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "User ID is required.")]
        public string UserID { get; set; }

        [DisplayName("User Type ID")]
        [Required(ErrorMessage = "User Type ID is required.")]
        public int UserTypeID { get; set; }
    }
}