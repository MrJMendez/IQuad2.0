using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Security;
using IQuad2.ViewModels;

namespace IQuad2.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;
        public UserService()
        {
            _context = new ApplicationDbContext();
        }

        public List<UserVm> GetUsers()
        {
            var users = _context.Users.ToList();
            var result = new List<UserVm>();
            foreach(var x in users)
            {
                var user = new UserVm();
               
                foreach( var r in x.Roles.ToList())
                {
                  var role =  _context.Roles.FirstOrDefault(a => a.Id == r.RoleId);
                    if (role != null)
                    {
                        user.RolesString.Add(role.Name);
                    }
                   
                   
                };

                user.user=x;

                result.Add(user);
               
            }
            return result;
           
        }

        public List<ApplicationUser> GetDoctors() {

            return _context.Users.Where(x => x.UserTypeId == (int)UserTypeEnum.Doctor).ToList();
        }
       
    }
   
}