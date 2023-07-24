namespace eShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using eShop.Data.Models;
    using System.Reflection.Metadata;

    public class OrderEntityConfiguartion : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasMany(c => c.OrderItems)
                .WithOne(c => c.Order)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
