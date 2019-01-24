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
            var viewModel = new DisplayCategoryViewModel();
            viewModel.CategoryList = _context.Categories.ToList();
            viewModel.Products = _context.Products.ToList();
            return View(viewModel);
        }
    }
}