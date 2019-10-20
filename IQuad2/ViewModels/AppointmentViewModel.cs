using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQuad2.Models;

namespace IQuad2.ViewModels
{
    public class AppointmentViewModel
    {
        public int AppointNumber { get; set; }

        private string patientId;

        private string DoctorId;
        
        
        public string PurposeOfVisit { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }


        public AppointmentViewModel(string patientId, string doctorId)
        {

            this.patientId = patientId;
            this.DoctorId = doctorId;
        }
    }
}