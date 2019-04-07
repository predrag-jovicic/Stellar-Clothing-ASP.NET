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
    public class ProductVariantsController : Controller
    {
        private readonly WebStoreContext _context;

        public ProductVariantsController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: ProductVariants
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.ProductVariants.Include(p => p.Color).Include(p => p.Product).Include(p => p.Size);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: ProductVariants/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productVariant = await _context.ProductVariants
                .Include(p => p.Color)
                .Include(p => p.Product)
                .Include(p => p.Size)
                .FirstOrDefaultAsync(m => m.ProductVariant_Id == id);
            if (productVariant == null)
            {
                return NotFound();
            }

            return View(productVariant);
        }

        // GET: ProductVariants/Create
        public IActionResult Create()
        {
            ViewData["Color_id"] = new SelectList(_context.Colors, "Color_id", "Name");
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description");
            ViewData["Size_id"] = new SelectList(_context.Sizes, "Size_id", "Name");
            return View();
        }

        // POST: ProductVariants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductVariant_Id,Product_id,Size_id,Color_id,Quantity")] ProductVariant productVariant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productVariant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Color_id"] = new SelectList(_context.Colors, "Color_id", "Name", productVariant.Color_id);
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description", productVariant.Product_id);
            ViewData["Size_id"] = new SelectList(_context.Sizes, "Size_id", "Name", productVariant.Size_id);
            return View(productVariant);
        }

        // GET: ProductVariants/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productVariant = await _context.ProductVariants.FindAsync(id);
            if (productVariant == null)
            {
                return NotFound();
            }
            ViewData["Color_id"] = new SelectList(_context.Colors, "Color_id", "Name", productVariant.Color_id);
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description", productVariant.Product_id);
            ViewData["Size_id"] = new SelectList(_context.Sizes, "Size_id", "Name", productVariant.Size_id);
            return View(productVariant);
        }

        // POST: ProductVariants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ProductVariant_Id,Product_id,Size_id,Color_id,Quantity")] ProductVariant productVariant)
        {
            if (id != productVariant.ProductVariant_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productVariant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductVariantExists(productVariant.ProductVariant_Id))
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
            ViewData["Color_id"] = new SelectList(_context.Colors, "Color_id", "Name", productVariant.Color_id);
            ViewData["Product_id"] = new SelectList(_context.Products, "Product_id", "Description", productVariant.Product_id);
            ViewData["Size_id"] = new SelectList(_context.Sizes, "Size_id", "Name", productVariant.Size_id);
            return View(productVariant);
        }

        // GET: ProductVariants/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productVariant = await _context.ProductVariants
                .Include(p => p.Color)
                .Include(p => p.Product)
                .Include(p => p.Size)
                .FirstOrDefaultAsync(m => m.ProductVariant_Id == id);
            if (productVariant == null)
            {
                return NotFound();
            }

            return View(productVariant);
        }

        // POST: ProductVariants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var productVariant = await _context.ProductVariants.FindAsync(id);
            _context.ProductVariants.Remove(productVariant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductVariantExists(long id)
        {
            return _context.ProductVariants.Any(e => e.ProductVariant_Id == id);
        }
    }
}
