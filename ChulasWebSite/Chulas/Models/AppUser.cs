using Microsoft.AspNetCore.Identity;

namespace Chulas.Models
{
    public class AppUser : IdentityUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string? RoleNames { get; set; }
    }
}
