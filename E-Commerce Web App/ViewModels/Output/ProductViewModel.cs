using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class ProductViewModel
    {
        public int Product_id { get; set; }
        public ProductPhoto Photo { get; set; }
        public string Name { get; set; }
        public Price Price { get; set; }
    }
}
