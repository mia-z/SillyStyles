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
            viewModel.Products = _context.Products
            .Include(x => x.ProductCategory)
            .ToList();
            viewModel.CategoryList = _context.Categories.ToList();
            /*viewModel.CategoryListItems = new List<SelectListItem>();
            Ugly method for dropdown list ECH
            foreach(var c in viewModel.CategoryList)
            {
                viewModel.CategoryListItems.Add(
                    new SelectListItem() {
                        Text = c.CategoryName,
                        Value = c.CategoryName
                    }
                );
            }*/
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
                prod.ProductCategory = viewModel.CategoryList
                    .Where(x => x.CategoryName == viewModel.Category)
                    .FirstOrDefault();
                _context.Products.Add(prod);
                _context.SaveChanges();
            }

            viewModel.Products = _context.Products.ToList();
            return RedirectToAction("Products");
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
            return RedirectToAction("Category");
        }
    }
}