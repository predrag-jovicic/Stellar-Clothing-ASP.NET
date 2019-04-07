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
    public class VotesController : Controller
    {
        private readonly WebStoreContext _context;

        public VotesController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: Votes
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.Votes.Include(v => v.Option).Include(v => v.User);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: Votes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vote = await _context.Votes
                .Include(v => v.Option)
                .Include(v => v.User)
                .FirstOrDefaultAsync(m => m.Vote_id == id);
            if (vote == null)
            {
                return NotFound();
            }

            return View(vote);
        }

        // GET: Votes/Create
        public IActionResult Create()
        {
            ViewData["Option_id"] = new SelectList(_context.Options, "Option_id", "Name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Votes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Vote_id,UserId,Time,Option_id")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Option_id"] = new SelectList(_context.Options, "Option_id", "Name", vote.Option_id);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", vote.UserId);
            return View(vote);
        }

        // GET: Votes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vote = await _context.Votes.FindAsync(id);
            if (vote == null)
            {
                return NotFound();
            }
            ViewData["Option_id"] = new SelectList(_context.Options, "Option_id", "Name", vote.Option_id);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", vote.UserId);
            return View(vote);
        }

        // POST: Votes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Vote_id,UserId,Time,Option_id")] Vote vote)
        {
            if (id != vote.Vote_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoteExists(vote.Vote_id))
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
            ViewData["Option_id"] = new SelectList(_context.Options, "Option_id", "Name", vote.Option_id);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", vote.UserId);
            return View(vote);
        }

        // GET: Votes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vote = await _context.Votes
                .Include(v => v.Option)
                .Include(v => v.User)
                .FirstOrDefaultAsync(m => m.Vote_id == id);
            if (vote == null)
            {
                return NotFound();
            }

            return View(vote);
        }

        // POST: Votes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var vote = await _context.Votes.FindAsync(id);
            _context.Votes.Remove(vote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoteExists(long id)
        {
            return _context.Votes.Any(e => e.Vote_id == id);
        }
    }
}
