namespace eShop.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.OrderItem;

    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(QuantityMinValue, QuantityMaxValue)]
        public int Quantity { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }

        [Required]
        public virtual Product Product { get; set; } = null!;

        public virtual Order Order { get; set; } = null!;
    }
}
