namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository CategoryRepository { get; }
        IBookRepository BookRepository { get; }
        Task SaveAsync();
    }
}
