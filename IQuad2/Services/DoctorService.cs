using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQuad2.Services
{
    public class DoctorService
    {
        private readonly ApplicationDbContext _context;
        public DoctorService()
        {
            _context = new ApplicationDbContext();
        }

        public List<ApplicationUser> GetDoctors() {

            return _context.Users.Where(x => x.UserTypeId == (int)UserTypeEnum.Doctor).ToList();
        }
    }
}