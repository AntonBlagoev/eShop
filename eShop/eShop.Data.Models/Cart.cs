namespace eShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class Cart
    {
        public Cart()
        {
            this.Id = Guid.NewGuid();
            this.CartItems = new HashSet<CartItem>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        public decimal DeliveryPrice { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

        public bool IsOrdered { get; set; }

    }
}