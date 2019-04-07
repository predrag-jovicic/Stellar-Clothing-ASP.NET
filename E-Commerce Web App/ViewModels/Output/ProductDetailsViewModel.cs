using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int Product_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProductPhoto> Photos { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public double Price { get; set; }
        public double? Rating { get; set; }
    }
}
