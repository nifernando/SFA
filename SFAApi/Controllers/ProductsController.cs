using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SFAApi.Dto;
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
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ProductsController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpPost]
        public ActionResult<BaseControllerReturnObject> POST(ProductDto productDto)
        {
            var baseControllerReturnObject = new BaseControllerReturnObject();
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(productDto);
                _productService.Add(product);
                baseControllerReturnObject.StatusCode = StatusCodes.Status200OK;
                baseControllerReturnObject.Message = "Op was success";
                baseControllerReturnObject.Data = product;
                return baseControllerReturnObject;
            }
            else
            {
                baseControllerReturnObject.StatusCode = StatusCodes.Status400BadRequest;
                baseControllerReturnObject.Message = "Op was Failed";
                baseControllerReturnObject.Data = productDto;
            }
       
            return baseControllerReturnObject;
        }
    }
}
