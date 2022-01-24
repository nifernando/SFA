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
        public async Task<ActionResult<BaseControllerReturnObject>> POST(ProductDto productDto)
        {
           
            try
            {
                
                if (ModelState.IsValid)
                {
                    var product = _mapper.Map<Product>(productDto);
                    if (await _productService.AddAsync(product))
                    {
                        var newProduct = _mapper.Map<ProductDto>(product);
                        return CreateMessage(productDto, "Op was success", StatusCodes.Status200OK);
                    }
                    else
                    {
                        return CreateMessage(productDto, "Op was Failed", StatusCodes.Status400BadRequest);
                    }
                }
                else
                {
                    return CreateMessage(productDto, "Op was Failed", StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception ex)
            {
               return CreateMessage(ex, "Op was Failed", StatusCodes.Status500InternalServerError);
            }
           
        }
        private  BaseControllerReturnObject CreateMessage(object data, string errorMsg,int statusCode)
        {
            var baseControllerReturnObject = new BaseControllerReturnObject();
            baseControllerReturnObject.Data = data;
            baseControllerReturnObject.Message = errorMsg;
            baseControllerReturnObject.StatusCode = statusCode;
            return baseControllerReturnObject;
        }
    }
}
