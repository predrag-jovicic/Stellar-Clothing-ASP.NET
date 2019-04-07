using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class HomePageViewModel
    {
        public Slider Slider { get; set; }
        public IEnumerable<ProductViewModel> TopProducts { get; set; }
    }
}
