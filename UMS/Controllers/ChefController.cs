using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Data;

namespace UMS.Controllers
{
    public class ChefController : Controller
    {
        // GET: Chef
        public ActionResult ChefOrderList()
        {
            return View(new InvoiceRepository().GetAll());
        }
        public ActionResult ChefOrderDetails()
        {
            return View();
        }
    }
}