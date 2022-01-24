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
        public void Add(Product product)
        {
            _uow.ProductRepository.Add(product);
            string abc = _configuration.GetSection("appsettings")["URL"];
            _uow.Save();
        }
    }
}
