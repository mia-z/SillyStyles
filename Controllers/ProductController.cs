using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace SillyStyles.Controllers
{
    public class ProductController : Controller
    {
        private readonly SillyStylesDbContext _context;
        public ProductController(SillyStylesDbContext context)
        {
            _context = context;
        }
        public IActionResult Show(string slug) 
        {            
            var product = _context
            .Products
            .Include(x => x.Reviews)
            .FirstOrDefault(x => x.Slug == slug);

            return View(product);
        }
    }
}