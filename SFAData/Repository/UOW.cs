using SFAContracts.IRepositories;
using System.Threading.Tasks;

namespace SFAData.Repository
{
    public class UOW : IUOW
    {
        private readonly DataContext _dataContext;
       // public IProductRepository ProductRepository;
        public UOW(DataContext dataContext,IProductRepository productRepository)
        {
            _dataContext = dataContext;
            ProductRepository = productRepository;
        }

      public  IProductRepository ProductRepository { get ; set ; }

        //  IProductRepository ProductRepository => throw new System.NotImplementedException();

        // IProductRepository IUOW.ProductRepository => throw new System.NotImplementedException();

        //public IProductRepository ProductRepository
        //{
        //    get
        //    {
        //        if (_productRepository == null)
        //            _productRepository = new ProductRepository(_dataContext);
        //        return _productRepository;
        //    }
        //}

        public async Task<bool> SaveAsync()
        {
          return await _dataContext.SaveChangesAsync() > 0 ? true : false;
        }
    }
}
