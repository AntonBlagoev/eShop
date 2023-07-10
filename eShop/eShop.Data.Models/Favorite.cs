namespace eShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Favorite
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
