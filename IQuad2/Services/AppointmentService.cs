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

        public List<ApplicationUser> Users()
        {
            var users = _context.Users.ToList();

            return users;
        }
        public void SaveAppointment(Appointment appointment) {
            _context.appointment.Add(appointment);
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> AppointDetails(string id)
        {
            var appointment = _context.appointment.ToList().Where(a => a.PatientId == id);

            return appointment;
        }

       /* public Appointment Edit(string id )
        {
            var appointment = _context.appointment.SingleOrDefault(c => c.PatientId == id);
            return appointment;
        } */
    }
}