using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class FooterViewModel
    {
        public IEnumerable<FooterMenu> FooterFirstColumn {get; set;}
        public IEnumerable<HeadingMenu> FooterSecondColumn { get; set; }
        public IEnumerable<HeadingMenu> FooterThirdColumn { get; set; }
    }
}
