using Entities.Exceptions;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges)
        {
            return await _manager.CategoryRepository.GetAllAsync(trackChanges);
        }

        public async Task<Category> GetOneCategoryByIdAsync(int Id, bool trackChanges)
        {
            return await GetOneCategoryByIdAndCheckExists(Id, trackChanges);
        }
        private async Task<Category> GetOneCategoryByIdAndCheckExists(int id, bool trackChanges)
        {
            var category = await _manager.CategoryRepository.GetOneCategoryByIdAsync(id, trackChanges);
            if (category is null)
                throw new CategoryNotFoundException(id);

            return category;
        }
    }
}
