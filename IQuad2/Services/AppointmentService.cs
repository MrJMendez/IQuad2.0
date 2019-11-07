﻿using IQuad2.Models;
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
            var appointments = _context.appointment.Include(a => a.User).ToList();

            return appointments;
        }

        public AppointmentViewModel NewView()
        {
            var doctors = _context.Users.Where(x => x.UserTypeId == (int)UserTypeEnum.Doctor).ToList();

            var viewModel = new AppointmentViewModel
            {
                appointment = new Appointment(),
                Doctors = doctors

            };

            return viewModel;
        }

        public void SaveAppointment(Appointment appointment) {

            if(appointment.Id == 0)
            {
                _context.appointment.Add(appointment);
            }
            else
            {
               var appointmentInDb = _context.appointment.Single(a => a.Id == appointment.Id); 
                 
               // appointmentInDb.PatientId = appointment.PatientId;
                appointmentInDb.PurposeOfVisit = appointment.PurposeOfVisit;
                appointment.Date = appointment.Date;
                appointmentInDb.StartTime = appointment.StartTime;
                appointmentInDb.EndTime = appointment.EndTime;
                appointment.DoctorId = appointment.DoctorId;
            }
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> AppointDetails(string id)
        {
            var appointment = _context.appointment.Include(a => a.User).ToList().Where(a => a.PatientId == id);

            return appointment;
        }
        public Appointment AppointEdit(int id)
        {
            var appointment = _context.appointment.SingleOrDefault(a => a.Id == id);
             
            return appointment;
        }

    }
}