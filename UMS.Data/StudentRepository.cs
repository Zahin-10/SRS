using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public bool Delete(string id)
        {
            //Fetching student with related courses
            Student student = base.context.Students.Include(s => s.Courses).SingleOrDefault(s => s.Id == id);

            //Clearing all the registered courses
            student.Courses.Clear();

            //Now deleting the entity
            base.context.Students.Remove(student);

            return base.context.SaveChanges()>0;
        }

        public IEnumerable<Student> GetAllWithCourses()
        {
            return base.context.Students.Include(s => s.Courses).ToList();
        }

        public Student GetWithCourses(string id)
        {
            return base.context.Students.Include(s => s.Courses).Include(s=>s.Department).SingleOrDefault(s => s.Id == id);
        }

        public Student GetWithDepartment(string id)
        {
            return base.context.Students.Include(s => s.Department).SingleOrDefault(s=>s.Id == id);
        }

        public bool InsertWithDepartment(Student student, int departmentId)
        {
            Department department = base.context.Departments.SingleOrDefault(d => d.Id == departmentId);
            student.Department = department;
            base.context.Students.Add(student);
            return base.context.SaveChanges() > 0;
        }

        public bool UpdateWithDepartment(Student student, int departmentId)
        {
            Student studentToUpdate = base.context.Students.SingleOrDefault(s => s.Id == student.Id);
            studentToUpdate.Name = student.Name;
            studentToUpdate.Cgpa = student.Cgpa;
            Department department = base.context.Departments.SingleOrDefault(d => d.Id == departmentId);
            studentToUpdate.Department = department;
            base.context.Entry(studentToUpdate).State = EntityState.Modified;
            
            return base.context.SaveChanges() > 0;
        }

        public bool AddCourse(string studentId, int courseId)
        {
            this.Get(studentId).Courses.Add(base.context.Courses.SingleOrDefault(s => s.Id == courseId));
            return base.context.SaveChanges()>0;
        }

        public bool RemoveCourse(string studentId, int courseId)
        {
            this.GetWithCourses(studentId).Courses.Remove(context.Courses.SingleOrDefault(c=>c.Id==courseId));
            return base.context.SaveChanges() > 0;
        }


    }
}
