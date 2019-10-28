using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQuad2.ViewModels
{
    public class AppointmentViewModel 
    {
        public IEnumerable<ApplicationUser> Doctor { get; set; } 
        public Appointment appointment { get; set; }
        

     

        
    }
}