using UMS.Entity;
using System.Collections.Generic;

namespace UMS.Core.Interfaces
{
    public interface ICourseService: IDomainService<Course>
    {
        bool Delete(int id);
        IEnumerable<Course> GetAllWithStudents();
        Course GetWithStudents(int id);
    }
}
