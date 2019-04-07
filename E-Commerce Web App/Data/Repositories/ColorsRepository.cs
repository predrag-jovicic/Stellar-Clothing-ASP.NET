using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class ColorsRepository
    {
        private WebStoreContext context;

        public ColorsRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<Color> GetAvailableProductColorsBySize(int productID, int sizeID)
        {
            return this.context.ProductVariants
                .Where(p => p.Size_id == sizeID && p.Product_id == productID)
                .Select(p => p.Color)
                .Distinct();
        }
    }
}
