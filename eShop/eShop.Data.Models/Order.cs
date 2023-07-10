namespace eShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid CartId { get; set; }

        [Required]
        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        public DateTime CreationDate { get; set; }
    }
}
