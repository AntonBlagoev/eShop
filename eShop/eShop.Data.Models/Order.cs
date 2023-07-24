namespace eShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.Order;
    using Enums;


    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NoteMaxLength)]
        public string Note { get; set; } = null!;

        public decimal? TotalPrice { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        public OrderState OrderState { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public Guid UserId { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<OrderItem> OrderItems { get; set; } = null!;
    }
}
