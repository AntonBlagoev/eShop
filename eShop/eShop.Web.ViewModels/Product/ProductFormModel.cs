namespace eShop.Web.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    using Category;
    using static Common.EntityValidationConstants.Product;

    public class ProductFormModel
    {
        public ProductFormModel()
        {
            this.Categories = new HashSet<ProductSelectCategoryFormModel>();
        }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(WarrantyMinValue, WarrantyMaxValue)]
        public int Warranty { get; set; }

        [Required]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        [Display(Name = "Image Path")]
        public string ImagePath { get; set; } = null!;

        [Range(typeof(decimal),PriceMinValue, PriceMaxValue)]
        [RegularExpression(PriceRegExValidator)]
        public decimal Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required]
        public IEnumerable<ProductSelectCategoryFormModel> Categories { get; set; }
    }
}
