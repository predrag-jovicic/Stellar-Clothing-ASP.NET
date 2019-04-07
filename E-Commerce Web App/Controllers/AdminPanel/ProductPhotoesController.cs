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
    public class ProductPhotoesController : Controller
    {
        private readonly WebStoreContext _context;

        public ProductPhotoesController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: ProductPhotoes
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.ProductPhotos.Include(p => p.Product);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: ProductPhotoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productPhoto = await _context.ProductPhotos
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Photo_id == id);
            if (productPhoto == null)
            {
                return NotFound();
            }

            return View(productPhoto);
        }

        // GET: ProductPhotoes/Create
        public IActionResult Create()
        {
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description");
            return View();
        }

        // POST: ProductPhotoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Photo_id,Source,Alt,Product_id")] ProductPhoto productPhoto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productPhoto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description", productPhoto.Product_id);
            return View(productPhoto);
        }

        // GET: ProductPhotoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productPhoto = await _context.ProductPhotos.FindAsync(id);
            if (productPhoto == null)
            {
                return NotFound();
            }
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description", productPhoto.Product_id);
            return View(productPhoto);
        }

        // POST: ProductPhotoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Photo_id,Source,Alt,Product_id")] ProductPhoto productPhoto)
        {
            if (id != productPhoto.Photo_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productPhoto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductPhotoExists(productPhoto.Photo_id))
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
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description", productPhoto.Product_id);
            return View(productPhoto);
        }

        // GET: ProductPhotoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productPhoto = await _context.ProductPhotos
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Photo_id == id);
            if (productPhoto == null)
            {
                return NotFound();
            }

            return View(productPhoto);
        }

        // POST: ProductPhotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productPhoto = await _context.ProductPhotos.FindAsync(id);
            _context.ProductPhotos.Remove(productPhoto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductPhotoExists(int id)
        {
            return _context.ProductPhotos.Any(e => e.Photo_id == id);
        }
    }
}
