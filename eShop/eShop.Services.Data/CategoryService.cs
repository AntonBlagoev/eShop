namespace eShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Interfaces;
    using eShop.Data;
    using eShop.Web.ViewModels.Category;

    public class CategoryService : ICategoryService
    {
        private readonly eShopDbContext dbContext;
        public CategoryService(eShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<ProductSelectCategoryFormModel>> AllCategoriesAsync()
        {
            IEnumerable<ProductSelectCategoryFormModel> allCategories = await this.dbContext
                .Categories
                .AsNoTracking()
                .Select(c => new ProductSelectCategoryFormModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToArrayAsync();

            return allCategories;
        }
        public async Task<bool> ExistByIdAsync(int id)
        {
            bool exist = await this.dbContext
                .Categories
                .AnyAsync(c => c.Id == id);

            return exist;
        }
        public async Task<IEnumerable<string>> AllCategoryNamesAsync()
        {
            IEnumerable<string> allNames = await this.dbContext
                .Categories
                .Select(c => c.Name)
                .ToArrayAsync();

            return allNames;
        }





    }
}
