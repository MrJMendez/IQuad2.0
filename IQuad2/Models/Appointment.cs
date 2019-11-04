using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace IQuad2.Models
{
    public class Appointment
    {
        [Required]
        public int Id { get; set; }
       
        [Required]
        public string PatientId { get; set; }
     

        public string DoctorId { get; set; }
        [Display(Name = "Purpose of Visit")]
        public string PurposeOfVisit { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Start Time")]   
        public string StartTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        public string EndTime { get; set; }


    }
}