namespace eShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using eShop.Data.Models;

    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Laptops",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Desktop Computers",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Monitors",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Printers",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "SSD Disks",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "RAN Memories",
            };
            categories.Add(category);

            return categories.ToArray();
        }


    }
}
