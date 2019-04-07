using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.ViewModels.Input;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Web_App.Controllers
{
    [Route("api/[controller]")]
    public class EmailApi : Controller
    {
        private IEmailSender emailSender;
        public EmailApi(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> ContactingAdmin(ContactInput input)
        {
            if (ModelState.IsValid)
            {
                await this.emailSender.SendEmailAsync("predragjovicic333@gmail.com", $"{input.Tbname} contacted you via the Contact us page with an e-mail {input.Tbemail}.",input.Message);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
