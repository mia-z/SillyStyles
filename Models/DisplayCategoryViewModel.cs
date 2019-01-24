using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SillyStyles.Domain.Entities;

namespace SillyStyles
{
    public class DisplayCategoryViewModel
    {
        public string CurrentPage { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}