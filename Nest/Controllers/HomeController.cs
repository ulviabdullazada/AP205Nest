using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest.DAL;
using Nest.Models;
using Nest.ViewModels;
using System;
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
            HomeVM homeVM = new HomeVM()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                PopularCategories = await _context.Categories.Where(c=>c.IsDeleted==false).OrderByDescending(c=>c.Products.Count).Take(5).ToListAsync(),
                RandomCategories = await _context.Categories.Where(c=>c.IsDeleted==false).OrderBy(c => Guid.NewGuid()).Take(10).Include(c=>c.Products).ToListAsync(),
                Products = await _context.Products.OrderByDescending(p => p.StockCount).Where(p=>p.StockCount>0).Take(10).Include(p => p.ProductImages).Include(p => p.Category).ToListAsync(),
                RecentProducts = await _context.Products.OrderByDescending(p => p.Id).Take(3).Include(p => p.ProductImages).Include(p => p.Category).ToListAsync(),
                TopRatedProducts = await _context.Products.OrderByDescending(p => p.Raiting).Take(3).Include(p => p.ProductImages).Include(p => p.Category).ToListAsync()
            };
            return View(homeVM);
        }
    }
}
