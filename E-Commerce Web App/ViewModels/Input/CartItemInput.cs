using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels.Input
{
    public class CartItemInput
    {
        public long ProductVariantId { get; set; }
        public int Quantity { get; set; }
    }
}
