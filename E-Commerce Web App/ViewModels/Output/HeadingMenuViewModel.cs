using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class HeadingMenuViewModel
    {
        public List<HeadingMenuItem> Items { get; set; }
        public byte Count { get; set; }
    }
}
