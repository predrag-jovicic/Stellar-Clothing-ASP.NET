using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels.Input
{
    public class CartItem
    {
        public long ProductVariant_Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public double Price { get; set; }
        public ProductPhoto Photo { get; set; }
    }
}
