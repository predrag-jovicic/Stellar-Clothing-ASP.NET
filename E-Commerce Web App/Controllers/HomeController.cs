using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E_Commerce_Web_App.Models;
using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using E_Commerce_Web_App.ViewModels.Input;
using E_Commerce_Web_App.Extension_Methods;
using E_Commerce_Web_App.ViewModels.Output;

namespace E_Commerce_Web_App.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        SignInManager<User> signInManager;
        private readonly IAntiforgery antiForgeryService;
        public HomeController(UnitOfWork unitOfWork, SignInManager<User> signInManager, IAntiforgery antiForgeryService)
        {
            this.unitOfWork = unitOfWork;
            this.antiForgeryService = antiForgeryService;
            this.signInManager = signInManager;
        }
        [Route("")]
        public IActionResult Index()
        {
            Slider activeSlider = unitOfWork.Sliders.GetActiveSlider();
            IEnumerable<Product> topProducts = unitOfWork.Products.ProductsWithTheBiggestDiscount();
            HomePageViewModel vm = new HomePageViewModel();
            vm.Slider = activeSlider;
            vm.TopProducts = topProducts.Select(p => new ProductViewModel
            {
                Product_id = p.Product_id,
                Price = p.Prices.SingleOrDefault(pr => pr.Active == true),
                Name = p.Name,
                Photo = p.ProductPhotos.FirstOrDefault()
            });
            return View(vm);
        }
        [Route("author")]
        public IActionResult Author()
        {
            return View();
        }
        [Route("register")]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction(nameof(Login));
            }
            return View();
        }
        [Route("checkout")]
        [Authorize]
        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("shopping_cart");
            double? total = null;
            if(cart != null)
            {
                if (cart.Count > 0)
                {
                    total = cart.Sum(item => item.Price * item.Quantity);
                }
            }
            CartViewModel vm = new CartViewModel
            {
                CartItems = cart,
                Total = total
            };
            return View(vm);
        }
        [Route("contact")]
        public IActionResult Contact()
        {
            var poll = this.unitOfWork.Polls.GetActivePoll();
            var vm = new ActivePollViewModel();
            vm.Question = poll.Question;
            vm.Options = poll.Options;
            vm.Poll_id = poll.Poll_id;
            return View(vm);
        }
        [Route("login")]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction(nameof(Login));
            }
            return View();
        }
        [Authorize]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                HttpContext.Session.Clear();
                await signInManager.SignOutAsync();
                return RedirectToAction(nameof(Login));
            }
            else
            {
                return RedirectToAction(nameof(Login));
            }
        }
        [Route("products/{category}/{subcategory}/{page?}")]
        public IActionResult Products(string category, string subcategory, int page = 1)
        {
            string cat = category;
            string subcat = subcategory;
            var products = unitOfWork.Products.GetProductsByCategoryAndSubcategoryPagination(subcat, cat,page);
            ProductsViewModel vm = new ProductsViewModel();
            vm.Products = products.Select(p => new ProductViewModel
            {
                Product_id = p.Product_id,
                Name = p.Name,
                Price = p.Prices.SingleOrDefault(pr => pr.Active == true),
                Photo = p.ProductPhotos.FirstOrDefault()
            });
            vm.Subcategory = subcat.ToUpper();
            vm.TheHighestPrice = unitOfWork.Prices.TheHighestPrice();
            vm.TheSmallestPrice = unitOfWork.Prices.TheSmallestPrice();
            ViewBag.Subcategory = subcat;
            ViewBag.Category = cat;
            int numberOfProducts = unitOfWork.Products.GetNumberOfProductsByCategoryAndSubcategory(subcat, cat);
            if (numberOfProducts == 0)
                vm.NumberOfPages = 0;
            else
            {
                double productsPerPage = 9;
                vm.NumberOfPages = (int)Math.Ceiling(numberOfProducts / productsPerPage);
            }
            return View(vm);
        }
        [Route("product/{id}")]
        public IActionResult Single(int id)
        {
            ProductDetailsViewModel vm = new ProductDetailsViewModel();
            var product = unitOfWork.Products.GetProduct(id);
            vm.Name = product.Name;
            vm.Description = product.Description;
            vm.Photos = product.ProductPhotos;
            vm.Price = product.Prices.FirstOrDefault(p => p.Active == true).Net_price;
            vm.Sizes = product.ProductVariants.Where(p => p.Size != null).Select(p => p.Size).Distinct().ToList();
            vm.Colors = product.ProductVariants.Where(p => p.Color != null).Select(pv => pv.Color).Distinct().ToList();
            vm.Product_id = product.Product_id;
            if (product.Ratings.Any(r => r.Value > 0))
            {
                vm.Rating = product.Ratings.Average(r => r.Value);
            }
            else
                vm.Rating = null;
            return View("Single",vm);
        }
        [Route("error",Name = "Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
