using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SillyStyles.Domain.Entities;

namespace SillyStyles.Controllers
{
    public class CategoryController : Controller
    {
        private readonly SillyStylesDbContext _context;

        public CategoryController(SillyStylesDbContext context)
        {
            _context = context;
        }

        public IActionResult Show(string slug)
        {
            var viewModel = new DisplayCategoryViewModel();
            viewModel.CurrentPage = slug;
            viewModel.Products = _context.Products
            .Include(x => x.ProductCategory)
            .Where(x => x.ProductCategory.CategoryName == slug)
            .ToList();
            return View(viewModel);
        }
    }
}