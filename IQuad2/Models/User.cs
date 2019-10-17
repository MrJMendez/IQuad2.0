using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IQuad2.Models
{
    public class User
    {

        public string UserID { get; set; }

        [Required]
        [StringLength(255)]
        public string Fname { get; set; }
        [Required]
        [StringLength(255)]
        public string Lname { get; set; }

        public string Initial { get; set; }
        public byte Age { get; set; }
        public string PhoneNumber { get; set; }
        public char Gender { get; set; }
        public string District { get; set; }
        public string Parish { get; set; }
        public string Street { get; set; }
        public UserType userType { get; set; }
        public string UserTypeId { get; set; }

    }
}