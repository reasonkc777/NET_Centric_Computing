using Microsoft.AspNetCore.Mvc;
using DatabaseFirstDemo.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstDemo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DatabaseFirstDemoDbContext _context;

        public ProductsController(DatabaseFirstDemoDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
    }
}
