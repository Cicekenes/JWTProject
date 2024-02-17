using Microsoft.AspNetCore.Identity;

namespace JWTProject.Core.Models.Entities
{
    public class UserApp : IdentityUser
    {
        public string? City { get; set; } = "";
    }
}
