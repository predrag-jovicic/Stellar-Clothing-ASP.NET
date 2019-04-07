using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.Exceptions;
using E_Commerce_Web_App.Extension_Methods;
using E_Commerce_Web_App.Models;
using E_Commerce_Web_App.ViewModels.Input;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Web_App.Controllers
{
    [Route("api/[controller]")]
    public class OrderApi : Controller
    {
        private UnitOfWork unitOfWork;
        private UserManager<User> userManager;

        public OrderApi(UnitOfWork unitOfWork, UserManager<User> userManager)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            try
            {
                var cart = HttpContext.Session.Get<List<CartItem>>("shopping_cart");
                Order order = new Order
                {
                    Time = DateTime.UtcNow,
                    UserId = userManager.GetUserId(User)
                };
                this.unitOfWork.Orders.Create(order);
                for (int i=0; i < cart.Count;i++)
                {
                    var product = this.unitOfWork.ProductVariant.Get(cart[i].ProductVariant_Id);
                    this.unitOfWork.ProductVariant.UpdateQuantity(product, cart[i].Quantity, i);
                    Ordered o = new Ordered
                    {
                        Amount = cart[i].Quantity,
                        ProductVariant_Id = cart[i].ProductVariant_Id,
                        Order_Id = order.Order_id
                    };
                    this.unitOfWork.Ordered.Create(o);
                }
                await this.unitOfWork.Save();
                HttpContext.Session.Set("shopping_cart", new List<CartItem>());
                return Ok();
            }
            catch (ProductNotAvailableException e)
            {
                return StatusCode(409, e.NotAvailableProductSessionId);
            }
        }
    }
}
