namespace eShop.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Interfaces;
    using eShop.Web.ViewModels.Home;
    using eShop.Data;
    using Microsoft.EntityFrameworkCore;
    using eShop.Web.ViewModels.Product;
    using eShop.Data.Models;

    public class ProductService : IProductService
    {
        private readonly eShopDbContext dbContext;
        public ProductService(eShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexViewModel>> LastThreeProductsAsync()
        {
            IEnumerable<IndexViewModel> lastThreeProductsAsync = await this.dbContext
                .Products
                .OrderByDescending(p => p.CreatedOn)
                .Take(10)
                .Select(p => new IndexViewModel
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    ImagePath = p.ImagePath,
                    Description = p.Description,
                    Price = p.Price.ToString()
                })
                .ToArrayAsync();

            return lastThreeProductsAsync;
        }

        public async Task CreateAsync(ProductFormModel model)
        {
            Product product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Warranty = model.Warranty,
                ImagePath = model.ImagePath,
                CategoryId = model.CategoryId,
            };
            await this.dbContext.Products.AddAsync(product);
            await this.dbContext.SaveChangesAsync();
        }





    }
}
