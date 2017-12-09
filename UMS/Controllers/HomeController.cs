using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Core.Interfaces;
using UMS.Entity;

namespace UMS.Controllers
{
    public class HomeController : Controller
    {
        private IItemService service;
        private ICategoryService categoryservice;

        public HomeController(ICategoryService categoryservice, IItemService itemService)
        {
            this.categoryservice = categoryservice;
            this.service = itemService;

        }

        [HttpGet]
        public ActionResult Index()
        {
           
            return View(categoryservice.GetAll());
        }
    }
}