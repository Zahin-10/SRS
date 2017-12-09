using System.Collections.Generic;

namespace UMS.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Credit { get; set; }
        public List<Student> Students { get; set; }

        public Course()
        {
            Students = new List<Student>();
        }
    }
}
