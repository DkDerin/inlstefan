using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.ViewModels
{
    public class ProductCreateViewModel
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="* Please enter a Product name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "* Name must have min length of 3 and max Length of 50")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(1, 999999999, ErrorMessage = "Price must be more than 0")]
        [DisplayName("Price ($)")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        //dropdownlist
        public string CategoryName { get; set; }
        public List<SelectListItem> AvailableCategory { get;set;}

    }

    public class ProductEditViewModel
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "* You cant leave the Product name blank")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "* Name must have min length of 2 and max Length of 50")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(1, 999999999, ErrorMessage = "Price must be more than 0")]
        [DisplayName("Price ($)")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public List<SelectListItem> AvailableCategory { get; set; }
    }    
}