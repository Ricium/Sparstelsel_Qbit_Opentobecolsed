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

    public class Product
    {
        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product ID is required.")]
        public int ProductID { get; set; }

        [DisplayName("Product")]
        [Required(ErrorMessage = "Product is required.")]
        [StringLength(20, ErrorMessage = "Product may not be longer than 20 characters")]
        public int Products { get; set; }

        [DisplayName("Product Description")]
        [Required(ErrorMessage = "Product Description is required.")]
        [StringLength(50, ErrorMessage = "Product Description may not be longer than 50 characters")]
        public int ProductDescription { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; }

        [DisplayName("Total")]
        [Required(ErrorMessage = "Total is required.")]
        public decimal Total { get; set; }

        [DisplayName("BTW")]
        [Required(ErrorMessage = "BTW is required.")]
        public decimal BTW { get; set; }
    }
}