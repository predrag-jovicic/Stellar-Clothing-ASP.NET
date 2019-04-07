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
    public class OrdersController : Controller
    {
        private readonly WebStoreContext _context;

        public OrdersController(WebStoreContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var webStoreContext = _context.Orders.Include(o => o.User);
            return View(await webStoreContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Order_id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
