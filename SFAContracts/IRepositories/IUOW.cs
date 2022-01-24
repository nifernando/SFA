using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAContracts.IRepositories
{
   public interface IUOW
    {
        public IProductRepository ProductRepository { get; set; }
        Task<bool> SaveAsync();
    }
}
