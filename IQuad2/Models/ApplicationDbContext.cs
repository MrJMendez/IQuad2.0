using System.Data.Entity;

using Microsoft.AspNet.Identity.EntityFramework;

namespace IQuad2.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<User> users { get; set; }
        public DbSet<UserType> userType { get; set; }
       

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}