using IQuad2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQuad2.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _context;
        public AppointmentService()
        {
            _context = new ApplicationDbContext();
        }
        public void SaveAppointment(Appointment appointment) {
            _context.appointment.Add(appointment);
            _context.SaveChanges();
        }
    }
}