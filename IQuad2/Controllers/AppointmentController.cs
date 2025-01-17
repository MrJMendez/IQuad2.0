﻿using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using IQuad2.Models;
using IQuad2.ViewModels;
using IQuad2.Services;
using System.Collections.Generic;

namespace IQuad2.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        // GET: Appointment
        private readonly UserService _userService;
        private readonly AppointmentService _appointmentService;

        public AppointmentController()
        {
            _userService = new UserService();
            _appointmentService = new AppointmentService();
        }
        public ActionResult Index()
        {
            IEnumerable<Appointment> appointments = null;

            if (User.IsInRole("Admin"))
            {
                appointments = _appointmentService.GetAppointments();
                return View("ReadIndex", appointments);
            }
            if (User.IsInRole("Receptionist"))
            {
                appointments = _appointmentService.GetAppointments();
                return View("Index", appointments);
            }
            if (User.IsInRole("Doctor"))
            {
                appointments = _appointmentService.GetDoctorAppointments(User.Identity.GetUserId());
                return View("ReadIndex", appointments);
            }

            appointments = _appointmentService.GetPatientAppointments(User.Identity.GetUserId());

            return View(appointments);
        }
        public ActionResult Set_Appointment()
        {

            var viewModel = _appointmentService.NewView();

            return View("AppointmentForm" , viewModel); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Appointment appointment)
        {
            var patientId = User.Identity.GetUserId();
           

            appointment.PatientId = patientId;

            _appointmentService.SaveAppointment(appointment);
            return RedirectToAction("Appointment_Set", "Appointment");
        }
        [Authorize(Roles = "Patient, Receptionist")]
        public ActionResult Delete(int id)
        {
            _appointmentService.DeleteAppointment(id);
            return RedirectToAction("Index", "Appointment");
        }

        public ActionResult Details(string id)
        {
            var appointment = _appointmentService.AppointDetails(id);

                if(appointment == null)
            {
                return HttpNotFound();
            }

            return View(appointment);
        }
        [Authorize(Roles = "Patient, Receptionist")]
        public ActionResult Edit(int id)
        {
            var appointment = _appointmentService.AppointEdit(id);

            if(appointment == null)
            {
                return HttpNotFound();
            }
             
            var appoint = new AppointmentViewModel
            {
                appointment = appointment,  
                Doctors = _userService.GetDoctors(),
           
            };

            return View("AppointmentForm", appoint);
        }

        public ActionResult Appointment_Set()
        {
            return View();
        }
    }
}