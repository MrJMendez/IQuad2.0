using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IQuad2.Models;


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
            //var users = _context.Users.ToList();
           // var doctors = _context.Users.Where(x => x.UserTypeId == (int)UserTypeEnum.Doctor).ToList();

            return View(/*doctors*/);
        }
        public ActionResult Set_Appointment()
        {
             

            return View();

        }

        
    }
}