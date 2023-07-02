namespace Entities.Exceptions
{
    public class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException(int id) : base($"The Category with id: {id} could not found.")
        {
        }
    }
}
