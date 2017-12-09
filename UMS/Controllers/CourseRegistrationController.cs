using System.Web.Mvc;
using UMS.Entity;
using System.Collections.Generic;
using System.Linq;
using UMS.Core.Interfaces;

namespace UMS.Controllers
{
    public class CourseRegistrationController : Controller
    {
        IStudentService studentService;
        ICourseService courseService;

        //Dependancies will be INJECTED by the IoC container
        public CourseRegistrationController(IStudentService studentService, ICourseService courseService)
        {
            this.studentService = studentService;
            this.courseService = courseService;
        }

        [NonAction]
        public void PopulateUI(string selectedStudentId = "")
        {
            if (TempData["studentId"] != null)
                selectedStudentId = TempData["studentId"].ToString();

            //Loading Necessary Repository Objects
            ICollection<Course> courses = (ICollection<Course>)courseService.GetAllWithStudents();

            //Declaring Necessary View Objects
            ICollection<Course> registeredCourses = new List<Course>();
            ICollection<Course> unregisteredCourses = new List<Course>();
            List<SelectListItem> studentSelectList = new List<SelectListItem>();

            //Preparing View Objects
            SelectListItem option = new SelectListItem();
            option.Text = "Select...";
            option.Value = "";
            studentSelectList.Add(option);
            foreach (Student student in studentService.GetAll())
            {
                option = new SelectListItem();
                option.Text = student.Name;
                option.Value = student.Id.ToString();
                option.Selected = student.Id == selectedStudentId;
                studentSelectList.Add(option);
            }

            if (selectedStudentId != "")
            {
                foreach (var course in courses)
                {
                    if (course.Students.Any(s => s.Id == selectedStudentId))
                        registeredCourses.Add(course);
                    else
                        unregisteredCourses.Add(course);
                }
            }

            //Attaching the View Objects to the ViewBag
            ViewBag.studentSelectList = studentSelectList;
            ViewBag.registeredCourses = registeredCourses;
            ViewBag.unregisteredCourses = unregisteredCourses;
        }

        [HttpGet]
        public ActionResult Index()
        {
            PopulateUI();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string selectedStudentId)
        {
            PopulateUI(selectedStudentId);
            return View();
        }

        [HttpGet]
        public ActionResult Add(string studentId, int courseId)
        {
            studentService.AddCourse(studentId, courseId);
            TempData["studentId"] = studentId;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Remove(string studentId, int courseId)
        {
            studentService.RemoveCourse(studentId, courseId);
            TempData["studentId"] = studentId;
            return RedirectToAction("Index");
        }
    }
}