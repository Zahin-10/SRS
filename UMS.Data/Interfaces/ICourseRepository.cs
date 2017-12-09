using UMS.Entity;
using System.Collections.Generic;

namespace UMS.Data.Interfaces
{
    public interface ICourseRepository: IRepository<Course>
    {
        bool Delete(int id);
        IEnumerable<Course> GetAllWithStudents();
        Course GetWithStudents(int id);
    }
}
