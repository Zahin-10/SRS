using System;
using System.Collections.Generic;

namespace UMS.Entity
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Department()
        {
            Students = new List<Student>();
        }
    }
}
