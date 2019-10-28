using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IQuad2.Models;
using IQuad2.ViewModels;


namespace IQuad2.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        private ApplicationDbContext _context;

        public AppointmentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); 
        }
        public ActionResult Index()
        {
          

            return View();
        }
        public ActionResult Set_Appointment()
        {

            var viewModel = new AppointmentViewModel {

                Doctor = _context.User.Where(x => x.UserTypeId == (int)UserTypeEnum.Doctor).ToList(),
                // Id = _context.Users.Find("Id")
        };

              return View(viewModel); 
            

        }
        public ActionResult Create(AppointmentViewModel viewModel)
        {

            _context.appointment.Add(viewModel.appointment);
            _context.SaveChanges();
            return RedirectToAction("Appointment_Set", "Appointment");
        }
        public ActionResult Appointment_Set()
        {

            return View();
        }
      
        
    }
}