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

        [Required]
        [ForeignKey(nameof(CartId))]
        public Guid CartId { get; set; }

        [Required]
        public Cart Cart { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public Guid UserId { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; } = null!;

        public DateTime CreationDate { get; set; }

        [Required]
        public OrderState OrderState { get; set; }
    }
}
