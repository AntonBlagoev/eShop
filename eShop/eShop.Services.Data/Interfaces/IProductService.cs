namespace eShop.Services.Data.Interfaces
{
    using eShop.Web.ViewModels.Home;
    using eShop.Web.ViewModels.Product;

    public interface IProductService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeProductsAsync();

        Task CreateAsync(ProductFormModel model);

        
    }
}
