using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQuad2.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<ApplicationUser> User { get; set; }
        public UserType UserType { get; set; }

    }
}