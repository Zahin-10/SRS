using UMS.Core.Interfaces;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Core
{
    public class DepartmentService: DomainService<Department>, IDepartmentService
    {
        public bool Delete(int id)
        {
            return ((IDepartmentRepository)repository).Delete(id);
        }
    }
}
