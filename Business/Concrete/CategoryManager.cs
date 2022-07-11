using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public async Task AddAsync(Category category)
        {
            await _categoryDal.AddAsync(category);
        }
        public async Task DeleteAsync(Category category)
        {
            await _categoryDal.DeleteAsync(category);
        }
        public async Task<Category> GetByIdAsync(int id)
        {
            return await _categoryDal.GetAsync(x => x.Id == id);
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _categoryDal.GetAllAsync();
        }
        public async Task UpdateAsync(Category category)
        {
            await _categoryDal.UpdateAsync(category);
        }
    }
}
