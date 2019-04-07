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
    public class HeadingMenusController : Controller
    {
        private readonly WebStoreContext _context;

        public HeadingMenusController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: HeadingMenus
        public async Task<IActionResult> Index()
        {
            return View(await _context.HeadingMenus.ToListAsync());
        }

        // GET: HeadingMenus/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var headingMenu = await _context.HeadingMenus
                .FirstOrDefaultAsync(m => m.HeadingItem_id == id);
            if (headingMenu == null)
            {
                return NotFound();
            }

            return View(headingMenu);
        }

        // GET: HeadingMenus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HeadingMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HeadingItem_id,Link,Name,HasChildren,Parent,Item_Column")] HeadingMenu headingMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(headingMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(headingMenu);
        }

        // GET: HeadingMenus/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var headingMenu = await _context.HeadingMenus.FindAsync(id);
            if (headingMenu == null)
            {
                return NotFound();
            }
            return View(headingMenu);
        }

        // POST: HeadingMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("HeadingItem_id,Link,Name,HasChildren,Parent,Item_Column")] HeadingMenu headingMenu)
        {
            if (id != headingMenu.HeadingItem_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(headingMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeadingMenuExists(headingMenu.HeadingItem_id))
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
            return View(headingMenu);
        }

        // GET: HeadingMenus/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var headingMenu = await _context.HeadingMenus
                .FirstOrDefaultAsync(m => m.HeadingItem_id == id);
            if (headingMenu == null)
            {
                return NotFound();
            }

            return View(headingMenu);
        }

        // POST: HeadingMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var headingMenu = await _context.HeadingMenus.FindAsync(id);
            _context.HeadingMenus.Remove(headingMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeadingMenuExists(byte id)
        {
            return _context.HeadingMenus.Any(e => e.HeadingItem_id == id);
        }
    }
}
