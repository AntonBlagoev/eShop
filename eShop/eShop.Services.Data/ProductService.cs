namespace eShop.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Interfaces;
    using eShop.Web.ViewModels.Home;
    using eShop.Data;
    using Microsoft.EntityFrameworkCore;

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
                //.Take(6)
                .Select(p => new IndexViewModel
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    ImagePath = p.ImagePath
                })
                .ToArrayAsync();

            return lastThreeProductsAsync;
        }
    }
}
