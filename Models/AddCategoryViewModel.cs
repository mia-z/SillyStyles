using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SillyStyles.Domain.Entities;

namespace SillyStyles
{
    public class AddCategoryViewModel
    {
        [Required(ErrorMessage="Enter a name")]
        [StringLength(50, ErrorMessage="Please enter a length smaller than 50 characters")]
        public string CategoryName { get; set; }
        
        public List<Category> CategoryList { get; set; }
    }
}