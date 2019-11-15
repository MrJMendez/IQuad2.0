namespace IQuad2.Migrations
{
    using IQuad2.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IQuad2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(IQuad2.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var userTypes = new List<UserType>
            {
                new UserType{ Id= 1, Name="Admin", Description="This particular user has administrative access to the application and can perform managerial and above tasks" },
                new UserType{ Id= 2, Name="Doctor", Description="This user is a certified medical doctor" },
                new UserType{ Id= 3, Name="Receptionist", Description="This user is a employee that has been cleared to carry out various operations with patients" },
                new UserType{ Id= 4, Name="Patient",  Description="This user sets appointments and comes into office for medical checks" },
            };
            userTypes.ForEach(x => context.UserType.AddOrUpdate(y => y.Name, x));
            context.SaveChanges();

            var users = new List<ApplicationUser>
            {
                new ApplicationUser{Id= "162b98e3-2ba3-4c9a-a5f2-0f24ac5f7bbf",Fname = "Andrew", Lname = "Bowen", Email = "Andrew@gmail.com", EmailConfirmed = false, PasswordHash= "AENHWqn55Y06h8x0918UIybgfvL0hhZF1xyDhyScAAQBo4sVfOQdZoW2DDUIvC2ZKA==", SecurityStamp ="c0dd4757-5eda-4851-95de-3deb6e118796", PhoneNumber ="876-234-5666", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEndDateUtc= null, LockoutEnabled = true, AccessFailedCount =0, UserName="Andrew@gmail.com", Initial="K", Age = 30, Street ="Dominica02", District="Vinyard Town", Parish ="Kingston", UserTypeId = 2 },
                new ApplicationUser{Id= "19f895c8-381e-4d11-ac4a-b442de893eb4",Fname = "Janiel", Lname = "Lawrence", Email = "janiel@gmail.com", EmailConfirmed = false, PasswordHash= "ANxD6NYZ5omZeXNw088mL8rIfVmqOP5+BdWEY0IdrMIvTe4I4c6PZViuIpyQIWaTWg==", SecurityStamp ="91f90186-ea41-441c-9d9d-a21573dac0f4", PhoneNumber ="876-123-4567", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEndDateUtc= null, LockoutEnabled = true, AccessFailedCount =0, UserName="janiel@gmail.com", Initial="A", Age = 21, Street ="Laneo1", District="Aberdeen", Parish ="St.Elizabeth", UserTypeId = 4 },
                new ApplicationUser{Id= "3aab3fea-408f-4769-852c-1f81399450dc", Fname = "Tika", Lname = "Atkinson", Email = "tika@gmail.com", EmailConfirmed = false, PasswordHash= "ANoZgBonbOJb7uJj+NW+Fb+d/7pbgAm7hlJlb83yY9KpG9wPVgN9atZsRNstLiZlbw==", SecurityStamp ="9d48d039-122f-442f-9ea5-086b35a03f66", PhoneNumber ="876-234-9987", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEndDateUtc= null, LockoutEnabled = true, AccessFailedCount =0, UserName="tika@gmail.com", Initial="T", Age = 23, Street ="Lane02", District="Appleton", Parish ="St.Elizabeth", UserTypeId = 3 }, 
                new ApplicationUser{Id= "5362a2fc-3279-4768-ba5d-752113281164", Fname = "Aqil", Lname = "Reid", Email = "aqil@gmail.com", EmailConfirmed = false, PasswordHash= "APAQFxaP6IS1G6rCNj4KTtT3n7hTzK/mkX2RLDJth3C7cNji2PAjvVFCJspVW3XpLg==", SecurityStamp ="fccbc519-8a78-4aef-b82d-87ef8618974c", PhoneNumber ="876-123-5666", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEndDateUtc= null, LockoutEnabled = true, AccessFailedCount =0, UserName="aqil@gmail.com", Initial="Z", Age = 22, Street ="Courtney Ave", District="Vinyard Town", Parish ="Kingston", UserTypeId = 4 },
                new ApplicationUser{Id= "602eeaf8-f0a8-4ba0-a6fc-ba98592ffeac", Fname = "James", Lname = "Brown", Email = "james@gmail.com", EmailConfirmed = false, PasswordHash= "AEpd/ilJU1Dy2wvFZFdVLh5Z5kn8QlW09S242ZaBbCwsqfG8N3weSFjsy2azMKM3vA==", SecurityStamp ="7f00c2a5-7474-41f7-a792-ead470a71d11", PhoneNumber ="876-567-5666", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEndDateUtc= null, LockoutEnabled = true, AccessFailedCount =0, UserName="james@gmail.com", Initial="L", Age = 30, Street ="test", District="testD", Parish ="TestP", UserTypeId = 2 },
                new ApplicationUser{Id= "d41f247f-0270-45bc-9708-7eec6116b2c1", Fname = "Johnoy", Lname = "Mendez", Email = "johnoy@gmail.com", EmailConfirmed = false, PasswordHash= "ADgvjIDqf5DrQ+ZKuPTtOTGCERCTb0lI8e9/JdT/m+aacmUBng2racJDTq6zKs6TCQ==", SecurityStamp ="34510157-5048-4282-9fcf-f54458f2963b", PhoneNumber ="876-891-5666", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEndDateUtc= null, LockoutEnabled = true, AccessFailedCount =0, UserName="Admin@gmail.com", Initial="A", Age = 30, Street ="070 Street", District="Waltham", Parish ="Manchester", UserTypeId = 1 },
                new ApplicationUser{Id= "fd515e01-c244-44af-8986-fa08a6dedb74", Fname = "Mikhail", Lname = "Campbell", Email = "mikhail@gmail.com", EmailConfirmed = false, PasswordHash= "AFgFt0jcuWHvFN0laNdvs/WH8VJHI4zD4dg2SyCyvNq6XGu0v0zTAjy3ekCSC065/w==", SecurityStamp ="20c94a56-c835-4a79-bfd4-662656eacdaf", PhoneNumber ="876-234-4567", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEndDateUtc= null, LockoutEnabled = true, AccessFailedCount =0, UserName="mikhail@gmail.com", Initial="C", Age = 21, Street ="Whitlane", District="Spalding", Parish ="Manchester", UserTypeId = 4 }
            };

            users.ForEach(x => context.Users.AddOrUpdate(y => new { y.Fname, y.Lname }, x));
            context.SaveChanges();

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var roles = new List<string>
            {
                "Admin",
                "Doctor",
                "Receptionist",
                "Patient"
            };
          
            foreach (var role in roles)
            {
                //var found = roleManager.FindByName(role);
                //if (role == null)
                //{
                //    found = new IdentityRole(role);
                //    roleManager.Create(found);
                //}
                roleManager.Create(new IdentityRole(role));
            }

            userManager.AddToRole("162b98e3-2ba3-4c9a-a5f2-0f24ac5f7bbf", "Doctor");
            userManager.AddToRole("19f895c8-381e-4d11-ac4a-b442de893eb4", "Patient");
            userManager.AddToRole("3aab3fea-408f-4769-852c-1f81399450dc", "Receptionist");
            userManager.AddToRole("5362a2fc-3279-4768-ba5d-752113281164", "Patient");
            userManager.AddToRole("602eeaf8-f0a8-4ba0-a6fc-ba98592ffeac", "Doctor");
            userManager.AddToRole("d41f247f-0270-45bc-9708-7eec6116b2c1", "Admin");
            userManager.AddToRole("fd515e01-c244-44af-8986-fa08a6dedb74", "Patient");
            
        }
    }
}
