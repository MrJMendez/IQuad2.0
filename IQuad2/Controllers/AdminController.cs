using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IQuad2.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Message = "Your Admin page.";
            return View();
        }
        public ActionResult Admin()
        {
            ViewBag.Message = "Your Admin page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }


    }
}