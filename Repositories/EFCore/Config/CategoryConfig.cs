using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).IsRequired();

            builder.HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Computer Science"
                },
                new Category
            {
                Id = 2,
                CategoryName = "Network"
            },
                new Category
            {
                Id = 3,
                CategoryName = "Database Management Systems"
            }
                );
        }
    }
}
