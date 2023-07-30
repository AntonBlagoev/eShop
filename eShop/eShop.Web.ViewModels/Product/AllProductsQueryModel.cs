namespace eShop.Web.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    using Enums;
    using static Common.GeneralApplicationConstants;

    public class AllProductsQueryModel
    {
        public AllProductsQueryModel()
        {
            this.CurrentPage = DefaultPage;
            this.ProductsPerPage = EntitiesPerPage;

            this.Categories = new HashSet<string>();
            this.Products = new HashSet<ProductViewModel>();
        }

        public string? Category { get; set; }

        [Display(Name = "Search by product name")]
        public string? SearchString { get; set; }

        [Display(Name = "Sort Products By")]
        public ProductSorting ProductSorting { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Products per page")]
        public int ProductsPerPage { get; set; }

        public int TotalProducts { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
