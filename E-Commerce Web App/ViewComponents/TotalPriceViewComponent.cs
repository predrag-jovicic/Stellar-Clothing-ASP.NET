using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.Extension_Methods;
using E_Commerce_Web_App.ViewModels.Input;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewComponents
{
    public class TotalPriceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("shopping_cart");
            double sumPrice;
            if (cart.Any())
            {
                sumPrice = cart.Sum(item => item.Price * item.Quantity);
            }
            else
            {
                sumPrice = 0;
            }
            return View("TotalPrice", sumPrice);
        }
    }
}
