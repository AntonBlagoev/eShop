namespace eShop.Services.Data.Models.Product
{
    using eShop.Web.ViewModels.Product;

    public class AllProductsFilteredAndPagedServiceModel
    {
        public AllProductsFilteredAndPagedServiceModel()
        {
            this.Products = new HashSet<ProductViewModel>();
        }
        public int TotalProductsCount { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
