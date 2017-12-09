using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Models;

namespace UMS.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult PlaceOrder()
        {
            return View();
        }
    }
}