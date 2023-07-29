namespace eShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.Product;

    public class Product
    {
        public Product()
        {
            this.Reviews = new HashSet<Review>();
            this.Favorities = new HashSet<Favorite>();
            this.CartItems = new HashSet<CartItem>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(WarrantyMinValue, WarrantyMaxValue)]
        public int Warranty { get; set; }

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        [Display(Name = "Image Path")]
        public string ImagePath { get; set; } = null!;

        public double? Price { get; set; }
       
        [Required]
        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }

        [Required]
        public virtual Category Category { get; set; } = null!;

        public bool IsAvailable { get; set; } = true;

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Favorite> Favorities { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

    }
}
