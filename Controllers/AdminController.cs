using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var productValidation = new AddProductViewModel();
            productValidation.Products = _context.Products.ToList();

            return View(productValidation);
        }

        [HttpPost]
        public IActionResult Products(AddProductViewModel productValidation)
        {
            if (ModelState.IsValid)
            {
                var prod = new Product(
                    productValidation.Title,
                    productValidation.ImageUrl,
                    productValidation.Price,
                    productValidation.Description
                );
                _context.Products.Add(prod);
                _context.SaveChanges();
            }

            productValidation.Products = _context.Products.ToList();
            return View(productValidation);
        }
    }
}