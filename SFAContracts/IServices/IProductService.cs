using SFAModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAContracts.IServices
{
   public interface IProductService
    {
        Task<bool> AddAsync(Product product);
    }
}
