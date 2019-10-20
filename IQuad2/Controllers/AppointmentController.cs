using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IQuad2.ViewModels;

namespace IQuad2.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Set_Appoitment()
        {
            AppointmentViewModel appointment = new AppointmentViewModel("a", "b"); 

            return View(appointment);

        }
    }
}