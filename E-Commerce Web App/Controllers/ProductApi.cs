using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E_Commerce_Web_App.Models;
using E_Commerce_Web_App.ViewModels;
using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.ViewModels.Output;
using E_Commerce_Web_App.Extension_Methods;
using E_Commerce_Web_App.ViewModels.Input;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Web_App.Controllers
{
    [Route("/api/products/")]
    public class ProductApi : Controller
    {
        private UnitOfWork unitOfWork;
        public ProductApi(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [Route("filtersortproducts")]
        [HttpGet]
        public IActionResult FilterAndSortProducts(string subcategory, string category, string selectedsort, double pricemin, double pricemax)
        {
            var products = this.unitOfWork.Products.GetProductsFilterSort(subcategory, category, pricemin, pricemax, selectedsort);
            IEnumerable<AjaxFilterSortProductModel> data = products.Select(p => new AjaxFilterSortProductModel
            {
                Product_id = p.Product_id,
                Name = p.Name,
                Net_price = p.Prices.SingleOrDefault(pr => pr.Active == true).Net_price,
                Discount = p.Prices.SingleOrDefault(pr => pr.Active == true).Discount,
                Source = p.ProductPhotos.FirstOrDefault().Source,
                Alt = p.ProductPhotos.FirstOrDefault().Alt
            });
            return Ok(data);
        }

        [HttpGet]
        [Route("amount")]
        public IActionResult GetAmount(int productID, int? colorID, int? sizeID)
        {
            long productVariant;
            if(colorID == null)
            {
                AmountViewModel dto = new AmountViewModel();
                dto.Amount = this.unitOfWork.ProductVariant.GetAmountByChosenColor(productID, sizeID, out productVariant);
                dto.ProductVariantId = productVariant;
                return Ok(dto);
            }
            else if(sizeID == null)
            {
                AmountViewModel dto = new AmountViewModel();
                dto.Amount = this.unitOfWork.ProductVariant.GetAmountByChosenColor(productID, colorID, out productVariant);
                dto.ProductVariantId = productVariant;
                return Ok(dto);
            }
            else if(sizeID == null && colorID == null)
            {
                AmountViewModel dto = new AmountViewModel();
                dto.Amount = this.unitOfWork.ProductVariant.GetAmountByNothingChosen(productID, out productVariant);
                dto.ProductVariantId = productVariant;
                return Ok(dto);
            }
            else
            {
                AmountViewModel dto = new AmountViewModel();
                dto.Amount = this.unitOfWork.ProductVariant.GetAmountByChosenColorAndSize(productID,sizeID,colorID, out productVariant);
                dto.ProductVariantId = productVariant;
                return Ok(dto);
            }
        }

        [Route("getAvailableColors")]
        [HttpGet]
        public IActionResult GetAvailableColors(int sizeID, int productID)
        {
            return Ok(unitOfWork.Colors.GetAvailableProductColorsBySize(productID,sizeID));
        }

        [ValidateAntiForgeryToken]
        [Authorize]
        [Route("addtocart")]
        [HttpPost]
        public IActionResult AddToCart(CartItemInput model)
        {
            if (ModelState.IsValid)
            {
                var cart = HttpContext.Session.Get<List<CartItem>>("shopping_cart");
                var found = cart.SingleOrDefault(item => item.ProductVariant_Id == model.ProductVariantId);
                if(found != null)
                {
                    found.Quantity += model.Quantity;
                }
                else
                {
                    var product = this.unitOfWork.ProductVariant.GetProductVariant(model.ProductVariantId);
                    CartItem cartItem = new CartItem
                    {
                        ProductVariant_Id = product.ProductVariant_Id,
                        Color = product.Color,
                        Price = product.Product.Prices.SingleOrDefault(p => p.Active == true).Net_price,
                        Size = product.Size,
                        Name = product.Product.Name,
                        Quantity = model.Quantity,
                        Photo = product.Product.ProductPhotos.First()
                    };
                    cart.Add(cartItem);
                }
                HttpContext.Session.Set("shopping_cart",cart);
                return Ok();
            }
            else
            {
                return UnprocessableEntity();
            }
        }

        [ValidateAntiForgeryToken]
        [Authorize]
        [HttpDelete]
        [Route("emptycart")]
        public IActionResult RemoveAll()
        {
            HttpContext.Session.Set("shopping_cart", new List<CartItem>());
            return NoContent();
        }

        [ValidateAntiForgeryToken]
        [Authorize]
        [HttpDelete]
        [Route("removeitem/{id}")]
        public IActionResult Remove(int id)
        {
            var cartItems = HttpContext.Session.Get<List<CartItem>>("shopping_cart");
            cartItems.RemoveAt(id);
            HttpContext.Session.Set("shopping_cart", cartItems);
            return NoContent();
        }
    }
}
