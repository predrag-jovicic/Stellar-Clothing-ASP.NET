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
    public class OptionsController : Controller
    {
        private readonly WebStoreContext _context;

        public OptionsController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: Options
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.Options.Include(o => o.Poll);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: Options/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var option = await _context.Options
                .Include(o => o.Poll)
                .FirstOrDefaultAsync(m => m.Option_id == id);
            if (option == null)
            {
                return NotFound();
            }

            return View(option);
        }

        // GET: Options/Create
        public IActionResult Create()
        {
            ViewData["Poll_id"] = new SelectList(_context.Polls, "Poll_id", "Question");
            return View();
        }

        // POST: Options/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Option_id,Name,Poll_id")] Option option)
        {
            if (ModelState.IsValid)
            {
                _context.Add(option);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Poll_id"] = new SelectList(_context.Polls, "Poll_id", "Question", option.Poll_id);
            return View(option);
        }

        // GET: Options/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var option = await _context.Options.FindAsync(id);
            if (option == null)
            {
                return NotFound();
            }
            ViewData["Poll_id"] = new SelectList(_context.Polls, "Poll_id", "Question", option.Poll_id);
            return View(option);
        }

        // POST: Options/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Option_id,Name,Poll_id")] Option option)
        {
            if (id != option.Option_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(option);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OptionExists(option.Option_id))
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
            ViewData["Poll_id"] = new SelectList(_context.Polls, "Poll_id", "Question", option.Poll_id);
            return View(option);
        }

        // GET: Options/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var option = await _context.Options
                .Include(o => o.Poll)
                .FirstOrDefaultAsync(m => m.Option_id == id);
            if (option == null)
            {
                return NotFound();
            }

            return View(option);
        }

        // POST: Options/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var option = await _context.Options.FindAsync(id);
            _context.Options.Remove(option);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OptionExists(int id)
        {
            return _context.Options.Any(e => e.Option_id == id);
        }
    }
}
