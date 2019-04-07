using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Web_App.Controllers
{
    [Route("api/[controller]")]
    public class ProductVariantApi : Controller
    {
        UnitOfWork unitOfWork;
        public ProductVariantApi(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult GetProductVariant(int id)
        {
            return Ok(this.unitOfWork.ProductVariant.GetProductVariant(id));
        }
    }
}
