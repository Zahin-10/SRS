using System.Collections.Generic;

namespace UMS.Entity
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }

        public Department Department { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
    }
}
