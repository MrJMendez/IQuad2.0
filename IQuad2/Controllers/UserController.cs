using IQuad2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IQuad2.Controllers
{
    public class UserController : Controller
    {
        private UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        [Authorize(Roles = "Admin")]
        public ViewResult Index()
        {
            var users = _userService.GetUsers().ToList(); 

            return View(users);
        }



    }
}