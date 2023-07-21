namespace eShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.CartItem;

    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(QuantityMinValue ,QuantityMaxValue)]
        public int Quantity { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }

        [Required]
        public virtual Product Product { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(CartId))]
        public string CartId { get; set; } = null!;

        [Required]
        public virtual Cart Cart { get; set; } = null!;



    }
}
