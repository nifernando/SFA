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

        public ProductService(IUOW uow)
        {
            _uow = uow;
        }
        public void Add(Product product)
        {
            _uow.ProductRepository.Add(product);
            _uow.Save();
        }
    }
}
