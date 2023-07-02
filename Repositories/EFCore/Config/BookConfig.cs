using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            

            builder.HasData(
                new Book
            {
                Id = 1,
                Title = "Karagöz Ve Hacivat",
                Price = 75,
                CategoryId = 1
            },
                new Book
            {
                Id = 2,
                Title = "Mesnevi",
                Price = 175,
                CategoryId = 2
            }, 
                new Book
            {
                Id = 3,
                Title = "Devlet",
                Price = 317,
                CategoryId = 3
            });
            
        }
    }

}