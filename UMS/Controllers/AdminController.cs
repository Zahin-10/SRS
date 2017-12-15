using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Core.Interfaces;
using UMS.Data;
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
            return View("OrderList1", new InvoiceRepository().GetAll());
        }

        public ActionResult OrderDetail(int id)
        {
            return View(new OrdersRepository().GetAll().Where(s=>s.invoiceid==id));
        }

        public ActionResult DeleteItem()
        {
            int itemId = Int32.Parse(Request.QueryString["itemId"]);
            if (itemService.Delete(itemId))
            {
                return RedirectToAction("MenuList");
            }
            else
            {
                return RedirectToAction("MenuList");
            }
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
        public ActionResult MenuList(string foodname,string category,string Price)
        {
            Item newitem = new Item();
            newitem.name = foodname;
            newitem.CategoryId = Int32.Parse(category);
            newitem.price = Decimal.Parse(Price);
            newitem.itemType = 1;
            newitem.PromoId = 4;
            if (itemService.Insert(newitem))
            {
                return RedirectToAction("MenuList");
            }
            ViewBag.Message = "Not Successful";
            return View();
        }
        [HttpGet]
        public ActionResult EditMenuList()
        {
            int id = Int32.Parse(Request.QueryString["itemId"]);
            ViewBag.item = itemService.GetAllWithPromoById(id);
            return View();
        }
        [HttpPost]
        public ActionResult EditMenuList(string itemtype,string itemid, string foodname, string categoryname, string price, string promoid, string categoryid)
        {
            Item itemtoupdate = new Item();
            itemtoupdate.Id = Int32.Parse(itemid);
            itemtoupdate.name = foodname;
            itemtoupdate.price = decimal.Parse(price);
            itemtoupdate.CategoryId = Int32.Parse(categoryid);
            itemtoupdate.PromoId  = Int32.Parse(promoid);
            itemtoupdate.itemType = Int32.Parse(itemtype);
            itemService.Update(itemtoupdate);
            return RedirectToAction("MenuList");
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