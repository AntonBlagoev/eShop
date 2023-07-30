namespace eShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.ApplicationUser;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();

            this.Orders = new HashSet<Order>();
            this.Favorites = new HashSet<Favorite>();
            this.Reviews = new HashSet<Review>();
        }

        [StringLength(FirstNameMaxLength)]
        public string? FirstName { get; set; } = null!;

        [StringLength(LastNameMaxLength)]
        public string? LastName { get; set; }

        [StringLength(AddressMaxLength)]
        public string? Address { get; set; }

        [StringLength(CityMaxLength)]
        public string? City { get; set; }

        [StringLength(PostalCodeMaxLength)]
        public string? PostalCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
