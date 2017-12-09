using UMS.Entity;
using System.Web.Mvc;
using UMS.Core.Interfaces;

namespace UMS.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService service;

        //Dependancy will be INJECTED by the IoC container
        public DepartmentController(IDepartmentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (service.Insert(department))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Not Successful";
            return View(department);
        }

        [HttpGet]
        public ActionResult Index()
        {            
            return View(service.GetAll());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(service.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Department department)
        {
            if (service.Update(department))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Not Successful";
            return View(department);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(service.Get(id));
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(service.Get(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DoDelete(int id)
        {
            if (service.Delete(id))
            {
                return RedirectToAction("Index");
            }            
            ViewBag.Message = "Not Successful";
            return View(service.Get(id));
        }
    }
}