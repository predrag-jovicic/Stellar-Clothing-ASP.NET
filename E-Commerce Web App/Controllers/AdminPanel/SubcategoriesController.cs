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
    public class SubcategoriesController : Controller
    {
        private readonly WebStoreContext _context;

        public SubcategoriesController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: Subcategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subcategories.ToListAsync());
        }

        // GET: Subcategories/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcategory = await _context.Subcategories
                .FirstOrDefaultAsync(m => m.Subcategory_id == id);
            if (subcategory == null)
            {
                return NotFound();
            }

            return View(subcategory);
        }

        // GET: Subcategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subcategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Subcategory_id,Name")] Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subcategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subcategory);
        }

        // GET: Subcategories/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcategory = await _context.Subcategories.FindAsync(id);
            if (subcategory == null)
            {
                return NotFound();
            }
            return View(subcategory);
        }

        // POST: Subcategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Subcategory_id,Name")] Subcategory subcategory)
        {
            if (id != subcategory.Subcategory_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subcategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubcategoryExists(subcategory.Subcategory_id))
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
            return View(subcategory);
        }

        // GET: Subcategories/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcategory = await _context.Subcategories
                .FirstOrDefaultAsync(m => m.Subcategory_id == id);
            if (subcategory == null)
            {
                return NotFound();
            }

            return View(subcategory);
        }

        // POST: Subcategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var subcategory = await _context.Subcategories.FindAsync(id);
            _context.Subcategories.Remove(subcategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubcategoryExists(byte id)
        {
            return _context.Subcategories.Any(e => e.Subcategory_id == id);
        }
    }
}
