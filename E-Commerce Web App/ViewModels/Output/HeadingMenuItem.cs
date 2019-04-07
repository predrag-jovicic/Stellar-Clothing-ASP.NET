using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class HeadingMenuItem
    {
        public byte HeadingItem_id { get; set; }
        public String Link { get; set; }
        public String Name { get; set; }
        public bool HasChildren { get; set; }
        public byte Parent { get; set; }
        public byte Item_Column { get; set; }
        public List<HeadingMenu> Children { get; set; }
    }
}
