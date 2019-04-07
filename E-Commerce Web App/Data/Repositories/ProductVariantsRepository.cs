using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Exceptions;
using E_Commerce_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class ProductVariantsRepository
    {
        private WebStoreContext context;
        public ProductVariantsRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public ProductVariant Get(long id)
        {
            return this.context.ProductVariants.SingleOrDefault(p => p.ProductVariant_Id == id);
        }

        public void UpdateQuantity(ProductVariant productVariant, int quantity, int index)
        {
            if(productVariant.Quantity - quantity >= 0)
            {
                productVariant.Quantity -= quantity;
            }
            else
            {
                throw new ProductNotAvailableException(index);
            }
        }

        public ProductVariant GetProductVariant(long id)
        {
            return this.context.ProductVariants
                .Include(pv => pv.Product)
                    .ThenInclude(pv => pv.Prices)
                .Include(pv => pv.Product)
                    .ThenInclude(pv => pv.ProductPhotos)
                .Include(pv => pv.Size)
                .Include(pv => pv.Color)
                .SingleOrDefault(pv => pv.ProductVariant_Id == id);
        }

        public int GetAmountByNothingChosen(int productID, out long variantId)
        {
            var found = this.context.ProductVariants
                .SingleOrDefault(p => p.Product_id == productID);
            variantId = found.ProductVariant_Id;
            return found.Quantity;
        }

        public int GetAmountByChosenColor(int productID, int? colorID, out long variantId)
        {
            var found = this.context.ProductVariants
                .SingleOrDefault(p => p.Color_id == colorID && p.Product_id == productID);
            variantId = found.ProductVariant_Id;
            return found.Quantity;
        }

        public int GetAmountByChosenSize(int productID, int? sizeID, out long variantId)
        {
            var found = this.context.ProductVariants
                .SingleOrDefault(p => p.Size_id == sizeID && p.Product_id == productID);
            variantId = found.ProductVariant_Id;
            return found.Quantity;
        }

        public int GetAmountByChosenColorAndSize(int productID, int? sizeID, int? colorID, out long variantId)
        {
            var found = this.context.ProductVariants
                .SingleOrDefault(p => p.Color_id == colorID && p.Size_id == sizeID && p.Product_id == productID);
            variantId = found.ProductVariant_Id;
            return found.Quantity;
        }
    }
}
