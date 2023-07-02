using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RepositoryManager(RepositoryContext context
            ,IBookRepository bookRepository
            ,ICategoryRepository categoryRepository)
        {
            _context = context;
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IBookRepository BookRepository => _bookRepository;

        public ICategoryRepository CategoryRepository => _categoryRepository;

        public async Task SaveAsync()
        {
           await  _context.SaveChangesAsync();
        }
    }
}
