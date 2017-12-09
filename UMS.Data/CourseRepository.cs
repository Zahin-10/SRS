using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace UMS.Data
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public bool Delete(int id)
        {
            //Fetching course with related students
            Course course = base.context.Courses.Include(c => c.Students).SingleOrDefault(c => c.Id == id);

            //Clearing the registered students
            course.Students.Clear();

            //Now deleting the entity
            base.context.Courses.Remove(course);

            return base.context.SaveChanges() > 0;
        }

        public IEnumerable<Course> GetAllWithStudents()
        {
            return base.context.Courses.Include(c=>c.Students).ToList();
        }

        public Course GetWithStudents(int id)
        {
            return base.context.Courses.Include(c => c.Students).SingleOrDefault(c => c.Id == id);
        }
    }
}
