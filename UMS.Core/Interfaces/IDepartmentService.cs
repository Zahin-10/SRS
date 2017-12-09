using UMS.Entity;

namespace UMS.Core.Interfaces
{
    public interface IDepartmentService: IDomainService<Department>
    {
        bool Delete(int id);
    }
}
