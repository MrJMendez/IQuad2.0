using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQuad2.ViewModels
{
    public class AppointmentViewModel 
    {
        public IEnumerable<User> Doctor { get; set; } 
        public Appointment appointment { get; set; }
        public IEnumerable<string> Id { get; set; }

        public AppointmentViewModel()
        {

        }
       /* public AppointmentViewModel(string number)
        {
            var user = new User();
            Id = number;
        }*/

        
    }
}