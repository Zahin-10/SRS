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
        public IItemService itemService;
        public ICategoryService categoryService;
        public AdminController(IItemService itemService, ICategoryService categoryService)
        {
            this.itemService = itemService;
            this.categoryService = categoryService;
        }

        // GET: Admin
        public ActionResult OrderList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MenuList()
        {
            List<Category> categories = new List<Category>();
            int i = 0;
            foreach (Category category in categoryService.GetAll())
            {
                categories.Add(category);
            }
            ViewBag.categoryList = categories;
            return View(itemService.GetAllWithPromo());
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            if (service.Update(course))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Not Successful";
            return View(course);
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