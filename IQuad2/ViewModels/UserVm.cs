using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQuad2.ViewModels
{
    public class UserVm
    {
        public UserVm()
        {
            RolesString = new List<string>();
           // user = new List<ApplicationUser>();
        }
        public ApplicationUser user { get; set; }
        public List<string> RolesString { get; set; }
    }
}