using SFAContracts.IRepositories;
using SFAModels;

namespace SFAData.Repository
{
    public class ProductRepository:RepositoryBase<Product>,IProductRepository
    {
        public ProductRepository(DataContext context):base(context)
        {

        }
    }
}
