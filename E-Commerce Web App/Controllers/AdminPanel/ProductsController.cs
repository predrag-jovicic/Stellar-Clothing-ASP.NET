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
    public class ProductsController : Controller
    {
        private readonly WebStoreContext _context;

        public ProductsController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.Products.Include(p => p.Category).Include(p => p.Subcategory).Include(p => p.Type);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Subcategory)
                .Include(p => p.Type)
                .FirstOrDefaultAsync(m => m.Product_id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Category_id"] = new SelectList(_context.Categories, "Category_id", "Name");
            ViewData["Subcategory_id"] = new SelectList(_context.Subcategories, "Subcategory_id", "Name");
            ViewData["Type_id"] = new SelectList(_context.Types, "Type_id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Product_id,Name,Description,Category_id,Subcategory_id,Type_id")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Category_id"] = new SelectList(_context.Categories, "Category_id", "Name", product.Category_id);
            ViewData["Subcategory_id"] = new SelectList(_context.Subcategories, "Subcategory_id", "Name", product.Subcategory_id);
            ViewData["Type_id"] = new SelectList(_context.Types, "Type_id", "Name", product.Type_id);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Category_id"] = new SelectList(_context.Categories, "Category_id", "Name", product.Category_id);
            ViewData["Subcategory_id"] = new SelectList(_context.Subcategories, "Subcategory_id", "Name", product.Subcategory_id);
            ViewData["Type_id"] = new SelectList(_context.Types, "Type_id", "Name", product.Type_id);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Product_id,Name,Description,Category_id,Subcategory_id,Type_id")] Product product)
        {
            if (id != product.Product_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Product_id))
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
            ViewData["Category_id"] = new SelectList(_context.Categories, "Category_id", "Name", product.Category_id);
            ViewData["Subcategory_id"] = new SelectList(_context.Subcategories, "Subcategory_id", "Name", product.Subcategory_id);
            ViewData["Type_id"] = new SelectList(_context.Types, "Type_id", "Name", product.Type_id);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Subcategory)
                .Include(p => p.Type)
                .FirstOrDefaultAsync(m => m.Product_id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Product_id == id);
        }
    }
}
