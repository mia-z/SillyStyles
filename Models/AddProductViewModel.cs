using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SillyStyles.Domain.Entities;

namespace SillyStyles
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage="Enter a name")]
        [StringLength(50, ErrorMessage="Please enter a length smaller than 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage="Please enter a URL")]
        [Url(ErrorMessage="Please enter a valid URL")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage="Enter a price")]
        [Range(0, int.MaxValue, ErrorMessage="Please enter a valid price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage="Enter a description")]
        [StringLength(500)]
        public string Description { get; set; }

        public Category Category { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}