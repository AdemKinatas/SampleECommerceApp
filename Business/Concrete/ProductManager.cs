using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task AddAsync(Product product)
        {
            await _productDal.AddAsync(product);
        }

        public async Task DeleteAsync(Product product)
        {
            await _productDal.DeleteAsync(product);
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            return await _productDal.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productDal.GetAsync(x => x.Id == id);
        }

        public async Task<IList<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _productDal.GetAllAsync(x => x.CategoryId == categoryId);
        }

        public async Task UpdateAsync(Product product)
        {
            await _productDal.UpdateAsync(product);
        }
    }
}
