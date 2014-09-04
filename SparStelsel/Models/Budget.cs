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

    public class Budget
    {
        [DisplayName("Budget ID")]
        [Required(ErrorMessage = "Budget ID is required.")]
        public int BudgetID { get; set; }

        [DisplayName("Budget Date")]
        [Required(ErrorMessage = "Budget Date is required.")]
        public DateTime BudgetDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }
    }
}