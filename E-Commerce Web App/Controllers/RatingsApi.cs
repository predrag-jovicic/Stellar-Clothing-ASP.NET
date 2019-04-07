using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.Models;
using E_Commerce_Web_App.ViewModels.Input;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Web_App.Controllers
{
    [Route("api/[controller]")]
    public class RatingsApi : Controller
    {
        private UnitOfWork unitOfWork;
        private UserManager<User> userManager;
        public RatingsApi(UnitOfWork unitOfWork, UserManager<User> userManager)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("rateproduct")]
        public async Task<IActionResult> Post(RatingInput model)
        {
            string userId = this.userManager.GetUserId(User);
            if (this.unitOfWork.Ratings.HasAlreadyRated(userId, model.ProductId))
                return Conflict();
            else
            {
                this.unitOfWork.Ratings.RateProduct(userId, model.ProductId, model.Value);
                await this.unitOfWork.Save();
                return NoContent();
            }
        }
    }
}
