using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Nest.DAL;
using Nest.Models;
using System.IO;
using Nest.Utilies.Extensions;
using System.Threading.Tasks;
using Nest.Utilies;
using Microsoft.AspNetCore.Authorization;

namespace Nest.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private AppDbContext _context{ get;}

        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View(_context.Sliders);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Slider slider)
        {
            if (slider.Photo.CheckSize(200))
            {
                ModelState.AddModelError("Photo","File size must be less than 200kb");
                return View();
            }
            if (!slider.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "File must be image");
                return View();
            }
            slider.Image = await slider.Photo.SaveFileAsync(Path.Combine(Constant.ImagePath, "slider"));
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Slider slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();
            if (System.IO.File.Exists(Path.Combine(Constant.ImagePath, "slider",slider.Image)))
            {
                System.IO.File.Delete(Path.Combine(Constant.ImagePath, "slider", slider.Image));
            }
            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
