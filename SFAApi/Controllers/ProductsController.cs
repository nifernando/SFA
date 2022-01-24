using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFAContracts.IServices;
using SFAModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFAApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public IActionResult POST()
        {
            var product = new Product
            {
                Code = "001",
                Description = "Gold Mari"
            };
            _productService.Add(product);
            return Ok();
        }
    }
}
