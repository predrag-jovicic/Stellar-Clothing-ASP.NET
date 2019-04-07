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
    public class OrderedsController : Controller
    {
        private readonly WebStoreContext _context;

        public OrderedsController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: Ordereds
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.Ordereds.Include(o => o.Order).Include(o => o.ProductVariant);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: Ordereds/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordered = await _context.Ordereds
                .Include(o => o.Order)
                .Include(o => o.ProductVariant)
                .FirstOrDefaultAsync(m => m.Ordered_id == id);
            if (ordered == null)
            {
                return NotFound();
            }

            return View(ordered);
        }

        // GET: Ordereds/Create
        public IActionResult Create()
        {
            ViewData["Order_Id"] = new SelectList(_context.Orders, "Order_id", "UserId");
            ViewData["ProductVariant_Id"] = new SelectList(_context.ProductVariants, "ProductVariant_Id", "ProductVariant_Id");
            return View();
        }

        // POST: Ordereds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ordered_id,ProductVariant_Id,Order_Id,Amount")] Ordered ordered)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordered);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Order_Id"] = new SelectList(_context.Orders, "Order_id", "UserId", ordered.Order_Id);
            ViewData["ProductVariant_Id"] = new SelectList(_context.ProductVariants, "ProductVariant_Id", "ProductVariant_Id", ordered.ProductVariant_Id);
            return View(ordered);
        }

        // GET: Ordereds/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordered = await _context.Ordereds.FindAsync(id);
            if (ordered == null)
            {
                return NotFound();
            }
            ViewData["Order_Id"] = new SelectList(_context.Orders, "Order_id", "UserId", ordered.Order_Id);
            ViewData["ProductVariant_Id"] = new SelectList(_context.ProductVariants, "ProductVariant_Id", "ProductVariant_Id", ordered.ProductVariant_Id);
            return View(ordered);
        }

        // POST: Ordereds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Ordered_id,ProductVariant_Id,Order_Id,Amount")] Ordered ordered)
        {
            if (id != ordered.Ordered_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordered);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderedExists(ordered.Ordered_id))
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
            ViewData["Order_Id"] = new SelectList(_context.Orders, "Order_id", "UserId", ordered.Order_Id);
            ViewData["ProductVariant_Id"] = new SelectList(_context.ProductVariants, "ProductVariant_Id", "ProductVariant_Id", ordered.ProductVariant_Id);
            return View(ordered);
        }

        // GET: Ordereds/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordered = await _context.Ordereds
                .Include(o => o.Order)
                .Include(o => o.ProductVariant)
                .FirstOrDefaultAsync(m => m.Ordered_id == id);
            if (ordered == null)
            {
                return NotFound();
            }

            return View(ordered);
        }

        // POST: Ordereds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ordered = await _context.Ordereds.FindAsync(id);
            _context.Ordereds.Remove(ordered);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderedExists(long id)
        {
            return _context.Ordereds.Any(e => e.Ordered_id == id);
        }
    }
}
