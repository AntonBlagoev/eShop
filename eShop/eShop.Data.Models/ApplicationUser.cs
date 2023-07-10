namespace eShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();

            this.Orders = new HashSet<Order>();
            this.Favorites = new HashSet<Favorite>();
            this.Reviews = new HashSet<Review>();
        }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
