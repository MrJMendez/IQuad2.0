using System.Data.Entity;

using Microsoft.AspNet.Identity.EntityFramework;

namespace IQuad2.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Appointment> appointment { get; set; }
        public DbSet<Specialties> specialities { get; set; }
        public DbSet<DoctorSpecialty> doctorSpecialties { get; set; }
        

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