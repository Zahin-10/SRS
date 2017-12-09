using System;
using System.Collections.Generic;
using UMS.Core.Interfaces;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Core
{
    public class CourseService : DomainService<Course>, ICourseService
    {
        public bool Delete(int id)
        {
            return ((ICourseRepository)base.repository).Delete(id);
        }

        public IEnumerable<Course> GetAllWithStudents()
        {
            return ((ICourseRepository)base.repository).GetAllWithStudents();
        }

        public Course GetWithStudents(int id)
        {
            return ((ICourseRepository)base.repository).GetWithStudents(id);
        }
    }
}
