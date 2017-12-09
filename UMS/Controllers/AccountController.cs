using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Models;

namespace UMS.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            //If successful redirect to dashboard
            if(ModelState.IsValid)
                ViewBag.Message = "Implement Yourself :)";
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View(new RegistrationModel());
        }

        [HttpPost]
        public ActionResult Registration(RegistrationModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgetPassword(string email)
        {
            return View();
        }
    }
}