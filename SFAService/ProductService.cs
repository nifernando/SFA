using Microsoft.Extensions.Configuration;
using SFAContracts.IRepositories;
using SFAContracts.IServices;
using SFAModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAService
{
    public class ProductService : IProductService
    {
        private readonly IUOW _uow;
        private readonly IConfiguration _configuration;

        public ProductService(IUOW uow, IConfiguration configuration)
        {
            _uow = uow;
            _configuration = configuration;
        }
        public async Task<bool> AddAsync(Product product)
        {
            await _uow.ProductRepository.AddAsync(product);
            return await _uow.SaveAsync();
        }
    }
}
