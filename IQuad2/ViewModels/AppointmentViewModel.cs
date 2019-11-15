using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IQuad2.ViewModels
{
    public class AppointmentViewModel 
    {
        public List<ApplicationUser> Doctors { get; set; }
        public List<ApplicationUser> Patients { get; set; }
        public Appointment appointment { get; set; }
        public string PatientName { get; set; }
        

     

        
    }
}