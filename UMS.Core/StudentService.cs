using System;
using System.Collections.Generic;
using UMS.Core.Interfaces;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Core
{
    public class StudentService : DomainService<Student>
    {
        public bool Delete(string id)
        {
            return ((IStudentRepository)base.repository).Delete(id);
        }

        public IEnumerable<Student> GetAllWithCourses()
        {
            return ((IStudentRepository)base.repository).GetAllWithCourses();
        }

        public Student GetWithCourses(string id)
        {
            return ((IStudentRepository)base.repository).GetWithCourses(id);
        }

        public Student GetWithDepartment(string id)
        {
            return ((IStudentRepository)base.repository).GetWithDepartment(id);
        }

        public bool InsertWithDepartment(Student student, int departmentId)
        {            
            return ((IStudentRepository)base.repository).InsertWithDepartment(student, departmentId);
        }

        public bool UpdateWithDepartment(Student student, int departmentId)
        {
            return ((IStudentRepository)base.repository).UpdateWithDepartment(student, departmentId);
        }

        public bool AddCourse(string studentId, int courseId)
        {
            return ((IStudentRepository)base.repository).AddCourse(studentId, courseId);
        }

        public bool RemoveCourse(string studentId, int courseId)
        {
            return ((IStudentRepository)base.repository).RemoveCourse(studentId, courseId);
        }
    }
}
