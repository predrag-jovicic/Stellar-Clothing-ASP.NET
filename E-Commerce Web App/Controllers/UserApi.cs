using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Models;
using E_Commerce_Web_App.ViewModels.Input;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using E_Commerce_Web_App.Extension_Methods;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Web_App.Controllers
{
    [Route("api/user/")]
    public class UserApi : Controller
    {
        private SignInManager<User> signInManager;
        private UserManager<User> userManager;
        private IEmailSender emailSender;

        public object ClaimIdentity { get; private set; }

        public UserApi(SignInManager<User> signInManager, UserManager<User> userManager, IEmailSender emailSender)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.emailSender = emailSender;
        }
        [HttpPost]
        [Route("login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (User.Identity.IsAuthenticated)
                return BadRequest();
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByEmailAsync(model.Email);
                if (user == null)
                    return StatusCode(400, "You are not registered.");
                else if (!user.EmailConfirmed)
                    return StatusCode(400, "Your email address is not confirmed.");
                else
                {
                    var result = await signInManager.PasswordSignInAsync(user.UserName, model.Password,false,false);
                    if (result.Succeeded)
                    {
                        HttpContext.Session.Set("shopping_cart", new List<CartItem>());
                        return Ok();
                    }
                    else
                    {
                        return StatusCode(400, "Wrong password.");
                    }
                }
            }
            else
            {
                return UnprocessableEntity();
            }
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var random = new Random();
                var rndNumber = random.Next();
                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.Email.Split("@")[0] + rndNumber.ToString(),
                    PhoneNumber = model.PhoneNumber,
                    Country = model.Country,
                    HomeAddress = model.HomeAddress,
                    ZipCode = model.Zip,
                    DateOfBirth = new DateTime(model.Year, model.Month, model.Day),
                    CardNumber = model.PaymentCard,
                    CSC = model.CSC
                };
                var result = await this.userManager.CreateAsync(user,model.Password);
                if (result.Succeeded)
                {
                    string code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    string url = Url.Action("ConfirmEmail", "UserApi", new { userId = user.Id, token = code }, protocol: Request.Scheme);
                    await this.emailSender.SendEmailAsync(model.Email, "Stellar Clothing Website - Confirm your account", $"Confirm you e-mail by clicking <a href='{HtmlEncoder.Default.Encode(url)}'>here</a>.");
                    return Ok();
                }
                else
                {
                    StringBuilder stringBuilder = new StringBuilder("Errors:");
                    foreach(var r in result.Errors)
                    {
                        stringBuilder.Append($"\n{r.Description}");
                    }
                    return StatusCode(500,stringBuilder.ToString());
                }
            }
            else
            {
                return UnprocessableEntity();
            }
        }

        [HttpGet]
        [Route("confirmemail/{userId}/{token}")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            User user = await userManager.FindByIdAsync(userId);
            if (user == null)
                return BadRequest();
            else
            {
                var result = this.userManager.ConfirmEmailAsync(user, token);
                if (result.Result.Succeeded)
                {
                    return Redirect("/login");
                }
                else
                {
                    return Redirect("/login");
                }
            }
        }
    }
}
