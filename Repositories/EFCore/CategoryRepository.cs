using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneCategory(Category category)
        => Create(category);

        public void UpdateOneCategory(Category category)
        => Update(category);
        public void DeleteOneCategory(Category category)
        => Delete(category);

        public async Task<IEnumerable<Category>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                 .OrderBy(c => c.Id)
                 .ToListAsync();
        }

        public async Task<Category> GetOneCategoryByIdAsync(int id, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(id), trackChanges)
                .SingleOrDefaultAsync();
        }

        
    }
}
