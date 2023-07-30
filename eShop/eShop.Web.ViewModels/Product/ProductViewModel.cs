namespace eShop.Web.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int Warranty { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
