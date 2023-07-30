namespace eShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.Review;

    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }

        [Required]
        public Product Product { get; set; } = null!;

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ContentMaxLength)]
        public string? Content { get; set; }

        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        public DateTime Date { get; set; }
    }
}
