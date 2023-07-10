namespace eShop.Data.Models
{
    using Microsoft.EntityFrameworkCore;
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
        public string Description { get; set; } = null!;

        [Required]
        public int Warranty { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        public double Price { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Favorite> Favorities { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

    }
}
