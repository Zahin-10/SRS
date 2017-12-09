using UMS.Entity;
using System.Web.Mvc;
using UMS.Core.Interfaces;
using UMS.Models;
using System.Collections.Generic;

namespace UMS.Controllers
{
    public class StudentController : Controller
    {
        IStudentService service;
        IDepartmentService departmentService;

        //Dependancy will be INJECTED by the IoC container
        public StudentController(IStudentService service, IDepartmentService departmentService)
        {
            this.service = service;
            this.departmentService = departmentService;
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.departmentSelectList = GetDepartmentList();
            return View();
        }

        [NonAction]
        public List<SelectListItem> GetDepartmentList(int selectedDepartmentId=0)
        {
            List<SelectListItem> departmentSelectList = new List<SelectListItem>();
            foreach (Department department in departmentService.GetAll())
            {
                SelectListItem option = new SelectListItem();
                option.Text = department.Name;
                option.Value = department.Id.ToString();
                option.Selected = department.Id == selectedDepartmentId;
                departmentSelectList.Add(option);
            }
            return departmentSelectList;
        }

        [HttpPost]
        public ActionResult Create(int departmentId, Student student)
        {
            if (service.InsertWithDepartment(student, departmentId))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Not Successful";
            ViewBag.departmentSelectList = GetDepartmentList(departmentId);
            return View(student);
        }

        [HttpGet]
        public ActionResult Index()
        {            
            return View(service.GetAll());
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            Student student = service.GetWithDepartment(id);
            ViewBag.departmentSelectList = GetDepartmentList(student.Department.Id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(int departmentId, Student student)
        {
            if (service.UpdateWithDepartment(student, departmentId))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Not Successful";
            ViewBag.departmentSelectList = GetDepartmentList(departmentId);
            return View(student);
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            return View(service.Get(id));
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            return View(service.Get(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DoDelete(string id)
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