using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace IQuad2.Models
{
    public class Appointment
    {
        
     
        public int Id { get; set; }
       
        public string PatientId { get; set; }

        public string DoctorId { get; set; }
        [Display(Name = "Purpose of Visit")]
        public string PurposeOfVisit { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }
        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }


    }
}