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
    /// Transit model links to l_Transit. 
    /// Transit table is used to save transit
    /// 
    /// Used by: FK
    /// 
    /// Uses: Sy eie FK
    /// </summary>
    public class Transit
    {
        [DisplayName("Transit ID")]
        [Required(ErrorMessage = "Transit ID is required.")]
        //Vir varchar sit hierdie in: 
        //[StringLength(10,ErrorMessage = "Transit ID may not be longer than 10 characters")]
        public int TransitID { get; set; }

        [DisplayName("Date")]
        [Required(ErrorMessage = "Date is required.")]
        public DateTime ActualDate { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }
    }
}