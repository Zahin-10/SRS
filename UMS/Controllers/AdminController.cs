using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Core.Interfaces;
using UMS.Entity;

namespace SRS.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult OrderList()
        {
            return View();
        }

        public ActionResult MenuList()
        {
            return View();
        }

        public ActionResult CategoryList()
        {
            return View();
        }

        public ActionResult EmployeeList()
        {
            return View();
        }

        public ActionResult ComboPackList()
        {
            return View();
        }

        public ActionResult Discount()
        {
            return View();
        }
        
    }
}