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
        public string Products { get; set; }

        [DisplayName("Product Description")]
        [Required(ErrorMessage = "Product Description is required.")]
        [StringLength(50, ErrorMessage = "Product Description may not be longer than 50 characters")]
        public string ProductDescription { get; set; }

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

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "CreatedDate is required.")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("CompanyID")]
        [Required(ErrorMessage = "CompanyID is required.")]
        public int CompanyID { get; set; }

        [DisplayName("ModifiedDate")]
        [Required(ErrorMessage = "ModifiedDate is required.")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("ModifiedBy")]
        [Required(ErrorMessage = "ModifiedBy is required.")]
        public int ModifiedBy { get; set; }

        [DisplayName("Removed")]
        [Required(ErrorMessage = "Removed is required.")]
        public bool Removed { get; set; }

        [DisplayName("Supplier")]
        [Required(ErrorMessage = "Removed is required.")]
        public string supplierid { get; set; }
        public int SupplierID { get; set; }

    }
}