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

        public string DoctorId { get; set; }
        public string PatientId { get; set; }
        public Appointment appointment { get; set; }
        

     

        
    }
}