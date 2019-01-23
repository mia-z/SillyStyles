using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SillyStyles.Controllers
{
    public class HomeController : Controller
    {
        private readonly SillyStylesDbContext _context;
        public HomeController(SillyStylesDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            var ProductListFromDb = _context.Products.ToList();
            var viewModel = new AddProductViewModel { Products = ProductListFromDb };
            return View(viewModel);
        }
    }
}