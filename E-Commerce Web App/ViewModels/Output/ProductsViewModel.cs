using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Models;

namespace E_Commerce_Web_App.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public string Subcategory { get; set; }
        public int NumberOfPages { get; set; }
        public double TheSmallestPrice { get; set; }
        public double TheHighestPrice { get; set; }
    }
}
