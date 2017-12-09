using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace UMS.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult MenuView()
        {
            return View();
        }
    }
}