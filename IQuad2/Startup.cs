using IQuad2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Security.Claims;


[assembly: OwinStartupAttribute(typeof(IQuad2.Startup))]
namespace IQuad2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRoles();

        }

        private void createRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));



            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();

                user.Email = "Admin@gmail.com";
                user.UserName = "Admin@gmail.com";
                user.Fname = "Johnoy";
                user.Lname = "Mendez";
                user.Age = 23;
                user.Initial = "A";
                user.Street = "070 Street";
                user.District = "Waltham";
                user.Parish = "Manchester";
                user.PhoneNumber = "876-318-6436";
                user.UserTypeId = (int)UserTypeEnum.Admin;
              



                string userPWD = "!@#456Am";

                var chkUser = UserManager.Create(user, userPWD);

                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                }
            }

            if (!roleManager.RoleExists("Patient"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Patient";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Doctor"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Doctor";
                roleManager.Create(role);
            }
         
            if (!roleManager.RoleExists("Receptionist"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Receptionist";
                roleManager.Create(role);
            }
            






        }
    }

}
