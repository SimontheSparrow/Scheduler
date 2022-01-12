using Microsoft.AspNetCore.Identity;

namespace Scheduler.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set;}
    }
}
