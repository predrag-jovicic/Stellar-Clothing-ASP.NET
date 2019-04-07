using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class PricesRepository
    {
        private WebStoreContext context;

        public PricesRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public double TheHighestPrice()
        {
            return this.context.Prices.Max(p => p.Net_price);
        }

        public double TheSmallestPrice()
        {
            return this.context.Prices.Min(p => p.Net_price);
        }
    }
}
