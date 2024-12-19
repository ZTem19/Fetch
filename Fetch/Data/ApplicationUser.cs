using Microsoft.AspNetCore.Identity;

namespace FetchApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public int Age { get; set; }
    }

}
