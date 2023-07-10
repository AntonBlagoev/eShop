namespace eShop.Data
{
    using eShop.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class eShopDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public eShopDbContext(DbContextOptions<eShopDbContext> options)
            : base(options)
        {
        }
    }
}