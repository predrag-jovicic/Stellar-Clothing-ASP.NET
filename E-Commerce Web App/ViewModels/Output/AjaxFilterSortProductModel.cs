using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class AjaxFilterSortProductModel
    {
        public int Product_id { get; set; }
        public String Source { get; set; }
        public String Alt { get; set; }
        public double Net_price { get; set; }
        public double Discount { get; set; }
        public string Name { get; set; }
    }
}
