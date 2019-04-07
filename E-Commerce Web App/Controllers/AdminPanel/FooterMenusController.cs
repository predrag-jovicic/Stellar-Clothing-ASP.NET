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
    public class FooterMenusController : Controller
    {
        private readonly WebStoreContext _context;

        public FooterMenusController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: FooterMenus
        public async Task<IActionResult> Index()
        {
            return View(await _context.FooterMenus.ToListAsync());
        }

        // GET: FooterMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footerMenu = await _context.FooterMenus
                .FirstOrDefaultAsync(m => m.FooterItem_id == id);
            if (footerMenu == null)
            {
                return NotFound();
            }

            return View(footerMenu);
        }

        // GET: FooterMenus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FooterMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FooterItem_id,Link,Name")] FooterMenu footerMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footerMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footerMenu);
        }

        // GET: FooterMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footerMenu = await _context.FooterMenus.FindAsync(id);
            if (footerMenu == null)
            {
                return NotFound();
            }
            return View(footerMenu);
        }

        // POST: FooterMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FooterItem_id,Link,Name")] FooterMenu footerMenu)
        {
            if (id != footerMenu.FooterItem_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footerMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FooterMenuExists(footerMenu.FooterItem_id))
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
            return View(footerMenu);
        }

        // GET: FooterMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footerMenu = await _context.FooterMenus
                .FirstOrDefaultAsync(m => m.FooterItem_id == id);
            if (footerMenu == null)
            {
                return NotFound();
            }

            return View(footerMenu);
        }

        // POST: FooterMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var footerMenu = await _context.FooterMenus.FindAsync(id);
            _context.FooterMenus.Remove(footerMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FooterMenuExists(int id)
        {
            return _context.FooterMenus.Any(e => e.FooterItem_id == id);
        }
    }
}
