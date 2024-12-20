using Microsoft.AspNetCore.Identity;

namespace EduVerse.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
