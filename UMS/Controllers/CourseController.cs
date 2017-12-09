using UMS.Entity;
using System.Web.Mvc;
using UMS.Core.Interfaces;

namespace UMS.Controllers
{
    public class CourseController : Controller
    {
        ICourseService service;

        //Dependancy will be INJECTED by IoC container
        public CourseController(ICourseService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (service.Insert(course))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Not Successful";
            return View(course);
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
        public ActionResult Edit(Course course)
        {
            if (service.Update(course))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Not Successful";
            return View(course);
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
            return View();
        }
    }
}