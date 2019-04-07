using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class RatingsRepository
    {
        private WebStoreContext context;

        public RatingsRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public bool HasAlreadyRated(string userId, int productId)
        {
            return this.context.Ratings
                .Any(r => r.Product_id == productId && r.UserId == userId);
        }

        public void RateProduct(string userId, int productId, short rating)
        {
            Rating newRating = new Rating
            {
                Product_id = productId,
                Value = rating,
                UserId = userId
            };
            this.context.Ratings.Add(newRating);
        }
    }
}
