using IQuad2.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQuad2.ViewModels;

namespace IQuad2.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _context;
        
        public AppointmentService()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            var appointments = _context.appointment.ToList();


            return appointments;
        }
        public IEnumerable<Appointment> GetPatientAppointments(string patientId)
        {
            var appointments = _context.appointment.ToList().Where(a => a.PatientId == patientId);

            return appointments;
        }
        public IEnumerable<Appointment> GetDoctorAppointments(string doctorId)
        {
            var appointments = _context.appointment.ToList().Where(a => a.DoctorId == doctorId);

            return appointments;
        }



        public AppointmentViewModel NewView()
        {
            var doctors = _context.Users.Where(x => x.UserTypeId == (int)UserTypeEnum.Doctor).ToList();
            var patients = _context.Users.Where(x => x.UserTypeId == (int)UserTypeEnum.Patient).ToList();
            var viewModel = new AppointmentViewModel
            {
                appointment = new Appointment(),
                Doctors = doctors,
                Patients = patients,
             
               
            };
     
            return viewModel;
        }

        public void SaveAppointment(Appointment appointment) {

            
            if (appointment.Id == 0)
            {
                _context.appointment.Add(appointment);
            }
            else
            {
               var appointmentInDb = _context.appointment.Single(a => a.Id == appointment.Id); 
                 
                appointmentInDb.PurposeOfVisit = appointment.PurposeOfVisit;
                appointment.Date = appointment.Date;
                appointmentInDb.StartTime = appointment.StartTime;
                appointmentInDb.EndTime = appointment.EndTime;
                appointmentInDb.DoctorId = appointment.DoctorId;
            }
            _context.SaveChanges();
        }

        public void DeleteAppointment(int id)
        {

            var appointment = _context.appointment.SingleOrDefault(a => a.Id == id);

            if (appointment.Id == id)
            {
                _context.appointment.Remove(appointment);
            }
            
            _context.SaveChanges();
        }



        public IEnumerable<Appointment> AppointDetails(string id)
        {
            var appointment = _context.appointment.ToList().Where(a => a.PatientId == id);

            return appointment;
        }
        public Appointment AppointEdit(int id)
        {
            var appointment = _context.appointment.SingleOrDefault(a => a.Id == id);
             
            return appointment;
        }

    }
}