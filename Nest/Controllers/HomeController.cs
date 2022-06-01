using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest.DAL;
using Nest.Models;
using Nest.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context{ get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IQueryable<Product> query = _context.Products.Include(p => p.ProductImages).Include(p => p.Category).AsQueryable();
            HomeVM homeVM = new HomeVM()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.Where(c=>c.IsDeleted==false).ToListAsync(),
                RecentProducts = await query.OrderByDescending(p=>p.Id).Take(3).ToListAsync(),
                TopRatedProducts = await query.OrderByDescending(p=>p.Raiting).Take(3).ToListAsync()
            };
            return View(homeVM);
        }
    }
}
