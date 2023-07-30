namespace eShop.Services.Data.Interfaces
{
    using Models.Product;
    using eShop.Web.ViewModels.Home;
    using eShop.Web.ViewModels.Product;

    public interface IProductService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeProductsAsync();

        Task CreateAsync(ProductFormModel model);

        Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel);

        Task<ProductDetailsViewModel?> ProductDetailsAsync(string productId);

        
    }
}
