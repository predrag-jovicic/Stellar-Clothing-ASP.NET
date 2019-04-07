using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_Commerce_Web_App.Models;

namespace E_Commerce_Web_App.Controllers.AdminPanel
{
    public class SliderPhotoesController : Controller
    {
        private readonly WebStoreContext _context;

        public SliderPhotoesController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: SliderPhotoes
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.SliderPhotos.Include(s => s.Slider);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: SliderPhotoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliderPhoto = await _context.SliderPhotos
                .Include(s => s.Slider)
                .FirstOrDefaultAsync(m => m.Photo_id == id);
            if (sliderPhoto == null)
            {
                return NotFound();
            }

            return View(sliderPhoto);
        }

        // GET: SliderPhotoes/Create
        public IActionResult Create()
        {
            ViewData["Slider_id"] = new SelectList(_context.Sliders, "Slider_id", "Text");
            return View();
        }

        // POST: SliderPhotoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Photo_id,Source,Alt,Slider_id")] SliderPhoto sliderPhoto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sliderPhoto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Slider_id"] = new SelectList(_context.Sliders, "Slider_id", "Text", sliderPhoto.Slider_id);
            return View(sliderPhoto);
        }

        // GET: SliderPhotoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliderPhoto = await _context.SliderPhotos.FindAsync(id);
            if (sliderPhoto == null)
            {
                return NotFound();
            }
            ViewData["Slider_id"] = new SelectList(_context.Sliders, "Slider_id", "Text", sliderPhoto.Slider_id);
            return View(sliderPhoto);
        }

        // POST: SliderPhotoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Photo_id,Source,Alt,Slider_id")] SliderPhoto sliderPhoto)
        {
            if (id != sliderPhoto.Photo_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sliderPhoto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliderPhotoExists(sliderPhoto.Photo_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Slider_id"] = new SelectList(_context.Sliders, "Slider_id", "Text", sliderPhoto.Slider_id);
            return View(sliderPhoto);
        }

        // GET: SliderPhotoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliderPhoto = await _context.SliderPhotos
                .Include(s => s.Slider)
                .FirstOrDefaultAsync(m => m.Photo_id == id);
            if (sliderPhoto == null)
            {
                return NotFound();
            }

            return View(sliderPhoto);
        }

        // POST: SliderPhotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sliderPhoto = await _context.SliderPhotos.FindAsync(id);
            _context.SliderPhotos.Remove(sliderPhoto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SliderPhotoExists(int id)
        {
            return _context.SliderPhotos.Any(e => e.Photo_id == id);
        }
    }
}
