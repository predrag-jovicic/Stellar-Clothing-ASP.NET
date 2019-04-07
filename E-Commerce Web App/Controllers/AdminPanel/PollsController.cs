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
    public class PollsController : Controller
    {
        private readonly WebStoreContext _context;

        public PollsController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: Polls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Polls.ToListAsync());
        }

        // GET: Polls/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .FirstOrDefaultAsync(m => m.Poll_id == id);
            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        // GET: Polls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Polls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Poll_id,Question,Active")] Poll poll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poll);
        }

        // GET: Polls/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls.FindAsync(id);
            if (poll == null)
            {
                return NotFound();
            }
            return View(poll);
        }

        // POST: Polls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Poll_id,Question,Active")] Poll poll)
        {
            if (id != poll.Poll_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PollExists(poll.Poll_id))
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
            return View(poll);
        }

        // GET: Polls/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .FirstOrDefaultAsync(m => m.Poll_id == id);
            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        // POST: Polls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var poll = await _context.Polls.FindAsync(id);
            _context.Polls.Remove(poll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PollExists(short id)
        {
            return _context.Polls.Any(e => e.Poll_id == id);
        }
    }
}
