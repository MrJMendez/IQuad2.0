using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IQuad2.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;
        public UserService()
        {
            _context = new ApplicationDbContext();
        }

        public List<ApplicationUser> GetUsers()
        {
            var users = _context.Users.Include(u => u.UserType).ToList();
            return users;
        }

        public List<ApplicationUser> GetDoctors() {

            return _context.Users.Where(x => x.UserTypeId == (int)UserTypeEnum.Doctor).ToList();
        }
       
    }
}