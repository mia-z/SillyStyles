using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SillyStyles.Domain.Entities;

namespace SillyStyles.Controllers
{
    public class AdminController : Controller
    {
        private readonly SillyStylesDbContext _context;
        public AdminController(SillyStylesDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Products() 
        {
            var viewModel = new AddProductViewModel();
            viewModel.Products = _context.Products.ToList();
            viewModel.CategoryList = _context.Categories.ToList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Products(AddProductViewModel viewModel)
        {
            viewModel.CategoryList = _context.Categories.ToList();
            if (ModelState.IsValid)
            {
                var prod = new Product(
                    viewModel.Title,
                    viewModel.ImageUrl,
                    viewModel.Price,
                    viewModel.Description
                );
                Category catForProd = (Category) _context.Categories
                .Where(x => x.CategoryName == viewModel.Category.CategoryName);
                prod.ProductCategory = catForProd;
                _context.Products.Add(prod);
                _context.SaveChanges();
            }

            viewModel.Products = _context.Products.ToList();
            return View(viewModel);
        }

        public IActionResult Category()
        {
            var viewModel = new AddCategoryViewModel();
            viewModel.CategoryList = _context.Categories.ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Category(AddCategoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var cat = new Category(
                    viewModel.CategoryName
                );
                _context.Categories.Add(cat);
                _context.SaveChanges();
            }

            viewModel.CategoryList = _context.Categories.ToList();
            return View(viewModel);
        }
    }
}