using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using IQuad2.Models;
using IQuad2.ViewModels;
using IQuad2.Services;

namespace IQuad2.Controllers
{
   
    public class AppointmentController : Controller
    {
        // GET: Appointment
        private readonly DoctorService _doctorService;
        private readonly AppointmentService _appointmentService;

        public AppointmentController()
        {
            _doctorService = new DoctorService();
            _appointmentService = new AppointmentService();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose(); 
        //}
        public ActionResult Index()
        {

            var users = _appointmentService.Users();

            return View(users);
        }
        public ActionResult Set_Appointment()
        {

            var viewModel = new AppointmentViewModel {

                Doctors = _doctorService.GetDoctors()
              
        };

              return View(viewModel); 
            

        }
        [HttpPost]
        public ActionResult Create(Appointment appointment)
        {
            //User.Identity.
            //Get current logged on user's id. In this case it belongs to the patient

            var patientId = User.Identity.GetUserId();

            appointment.PatientId = patientId;
            

            /*var appointment = new Appointment {

                DoctorId = viewModel.DoctorId,
                PatientId = patientId,
                Date = viewModel.appointment.Date,
                PurposeOfVisit = viewModel.appointment.PurposeOfVisit,
                StartTime = viewModel.appointment.StartTime,
                EndTime = viewModel.appointment.EndTime
                
            };*/


            _appointmentService.SaveAppointment(appointment);
            return RedirectToAction("Appointment_Set", "Appointment");
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
        public ActionResult Appointment_Set()
        {
            /*
            Appointment cAppointment = new Appointment();

            cAppointment = _appointmentService.Edit(User.Identity.GetUserId());
            
            if(cAppointment == null)
            {
                return HttpNotFound();
            }

            AppointmentViewModel appointment = new AppointmentViewModel
            {
                appointment = cAppointment,
                PatientId = User.Identity.GetUserId(),
                Doctors = _doctorService.GetDoctors(),
                DoctorId = cAppointment.DoctorId
            };
                */

            return View(/*appointment*/);
        }
      
        
    }
}