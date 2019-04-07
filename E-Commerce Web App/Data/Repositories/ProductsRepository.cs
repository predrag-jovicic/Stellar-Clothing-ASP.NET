using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class ProductsRepository
    {
        WebStoreContext context;
        public ProductsRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProductsByCategoryAndSubcategory(string subcategory, string category)
        {
            var products = context.Products
                .Include(p => p.ProductPhotos)
                .Include(p => p.Prices)
                .Where(p => p.Category.Name == category && p.Subcategory.Name == subcategory);
            return products;
        }

        public IEnumerable<Product> GetProductsByCategoryAndSubcategoryPagination(string subcategory, string category, int page)
        {
            int skipNum = (page-1) * 9;
            var products = context.Products
               .Include(p => p.ProductPhotos)
               .Include(p => p.Prices)
               .Where(p => p.Category.Name == category && p.Subcategory.Name == subcategory)
               .Take(9)
               .Skip(skipNum);
            return products;
        }

        public IQueryable<Product> GetProductsFilterSort(string subcategory, string category, double priceMin, double priceMax, string sort)
        {
            IQueryable<Product> query = context.Products
                .Include(p => p.ProductPhotos)
                .Include(p => p.Prices)
                .Where(p => p.Category.Name == category && p.Subcategory.Name == subcategory);
            if (!sort.Contains("0"))
            {
                switch (sort)
                {
                    case "pasc":
                        query = query.OrderBy(p => p.Prices.SingleOrDefault(pr => pr.Active == true).Net_price);
                        break;
                    case "pdesc":
                        query = query.OrderByDescending(p => p.Prices.SingleOrDefault(pr => pr.Active == true).Net_price);
                        break;
                    case "discasc":
                        query = query.OrderBy(p => p.Prices.SingleOrDefault(pr => pr.Active == true).Discount);
                        break;
                    case "discdesc":
                        query = query.OrderByDescending(p => p.Prices.SingleOrDefault(pr => pr.Active == true).Discount);
                        break;
                }
            }
            return query.Where(p => p.Prices.SingleOrDefault(pr => pr.Active == true).Net_price >= priceMin && p.Prices.SingleOrDefault(pr => pr.Active == true).Net_price <= priceMax);
        }

        public int GetNumberOfProductsByCategoryAndSubcategory(string subcategory, string category)
        {
            return context.Products
                .Where(p => p.Category.Name == category && p.Subcategory.Name == subcategory)
                .Count();
        }

        public Product GetProduct(int id)
        {
            return this.context.Products
                .Include(p => p.ProductPhotos)
                .Include(p => p.ProductVariants)
                    .ThenInclude(pv => pv.Color)
                .Include(p => p.ProductVariants)
                    .ThenInclude(pv => pv.Size)
                .Include(p => p.Ratings)
                .Include(p => p.Prices)
                .SingleOrDefault(p => p.Product_id == id);
        }

        public IEnumerable<Product> ProductsWithTheBiggestDiscount()
        {
            var products = context.Products
                .Include(p => p.ProductPhotos)
                .Include(p => p.Prices)
                .OrderByDescending(p => p.Prices.SingleOrDefault(pr => pr.Active == true).Discount)
                .Take(4);
            return products;
        }
    }
}
