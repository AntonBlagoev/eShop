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
    using eShop.Services.Data.Models.Product;
    using eShop.Web.ViewModels.Product.Enums;

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
                .Where(p => p.IsAvailable)
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

        public async Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel)
        {
            IQueryable<Product> productsQuery = this.dbContext
                .Products
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.Category))
            {
                productsQuery = productsQuery
                    .Where(p => p.Category.Name == queryModel.Category);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                productsQuery = productsQuery
                    .Where(p => EF.Functions.Like(p.Name, wildCard) ||
                                EF.Functions.Like(p.Description, wildCard));
            }

            productsQuery = queryModel.ProductSorting switch
            {
                ProductSorting.Newest => productsQuery
                    .OrderByDescending(p => p.CreatedOn),
                ProductSorting.Oldest => productsQuery
                    .OrderBy(p => p.CreatedOn),
                ProductSorting.PriceAscending => productsQuery
                    .OrderBy(p => p.Price),
                ProductSorting.PriceDescending => productsQuery
                    .OrderByDescending(p => p.Price),
                _ => productsQuery
                .OrderBy(p => p.IsAvailable == true)
                .ThenByDescending(p => p.CreatedOn)
            };

            IEnumerable<ProductViewModel> allProducts = await productsQuery
                .Where(p => p.IsAvailable)
                .Skip((queryModel.CurrentPage - 1) * queryModel.ProductsPerPage)
                .Take(queryModel.ProductsPerPage)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    Description = p.Description,
                    Warranty = p.Warranty,
                    ImagePath = p.ImagePath,
                    Price = p.Price,
                })
                .ToArrayAsync();

            int totalProducts = productsQuery.Count();

            return new AllProductsFilteredAndPagedServiceModel()
            {
                TotalProductsCount = totalProducts,
                Products = allProducts
            };
        }

        public async Task<ProductDetailsViewModel?> ProductDetailsAsync(string productId)
        {
            Product? product = await this.dbContext
                .Products
                .Include(p => p.Category)
                .Where(p => p.IsAvailable)
                .FirstOrDefaultAsync(p => p.Id.ToString() == productId);

            if (product == null)
            {
                return null;
            }

            return new ProductDetailsViewModel
            {
                Id = product.Id.ToString(),
                Name = product.Name,
                Description = product.Description,
                Warranty = product.Warranty,
                Price = product.Price,
                Category = product.Category.Name,
                ImagePath = product.ImagePath
            };
        }
    }
}
