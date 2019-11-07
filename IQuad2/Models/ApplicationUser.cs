
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IQuad2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string Fname { get; set; }
        [Required]
        [StringLength(255)]
        public string Lname { get; set; }
        public string Initial { get; set; }

        [Required]
        public int Age { get; set; }
        public override string PhoneNumber { get; set; }

        public string Street { get; set; }
        [Required]
        [StringLength(255)]
        public string District { get; set; }

        [Required]
        [StringLength(255)]
        public string Parish { get; set; }
        public UserType UserType { get; set; }

        [Required]
        public int UserTypeId { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}