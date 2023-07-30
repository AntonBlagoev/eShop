namespace eShop.Services.Data.Interfaces
{
    using eShop.Web.ViewModels.Category;
    using Microsoft.AspNetCore.Identity;

    public interface ICategoryService
    {
        Task<IEnumerable<ProductSelectCategoryFormModel>> AllCategoriesAsync();
        Task<bool> ExistByIdAsync(int id);

        Task<IEnumerable<string>> AllCategoryNamesAsync();
    }
}
