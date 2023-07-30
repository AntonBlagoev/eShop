namespace eShop.Web.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    public class ProductDetailsViewModel : ProductViewModel
    {
        public string Category { get; set; } = null!;


    }
}
