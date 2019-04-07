using E_Commerce_Web_App.ViewModels.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels.Output
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public double? Total { get; set; }
    }
}
