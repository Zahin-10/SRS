using System.Collections.Generic;
using UMS.Entity;
using UMS.Data.Interfaces;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public bool Delete(int id)
        {
            //Fetching department with related students including courses
            Department department = base.context.Departments.Include("Students.Courses").SingleOrDefault(d => d.Id == id);
            
            //First removing all the child records
            base.context.Students.RemoveRange(department.Students);
            
            //Now deleting the entity
            base.context.Departments.Remove(department);

            return base.context.SaveChanges() > 0;
        }
    }
}
