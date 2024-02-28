using Microsoft.AspNetCore.Identity;
using Webshop.Models;

namespace Webshop.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<Product>? Cart { get; set; } = new();
    }

}
