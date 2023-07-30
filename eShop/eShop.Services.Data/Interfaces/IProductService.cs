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

        Task<bool> ExistByIdAsync(string productId);

        Task<ProductFormModel> GetProductEditByIdAsync(string productId);

        Task EditProductByIdAndFormModelAsync(string productId, ProductFormModel formModel);
    }
}
