using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Core.Interfaces;


namespace UMS.Controllers
{
    public class MenuController : Controller
    {

        private IItemService service;

        public MenuController(IItemService itemservice)
        {
            this.service = itemservice;
        }

        // GET: Menu
        public ActionResult MenuView()
        {
            int catid = Int32.Parse(Request.QueryString["catId"]);
            return View(service.GetAllWithPromoByCatId(catid));
        }
    }
}