using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IQuad2.Models
{
    public class Appointment
    {
        [Required]
        public int Id { get; set; }
      
        public string PatientId { get; set; }
        
        public virtual ApplicationUser Patient { get; set; }
        [Required]
        public string DoctorId { get; set; }
        public virtual ApplicationUser Doctor { get; set; }
        [Display(Name = "Purpose of Visit")]
        public string PurposeOfVisit { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Start Time")]   
        public DateTime StartTime { get; set; }
        [Required]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
        

    }
}