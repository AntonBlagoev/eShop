namespace eShop.Services.Data.Interfaces
{
    using eShop.Web.ViewModels.Home;

    public interface IProductService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeProductsAsync();
    }
}
