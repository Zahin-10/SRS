using UMS.Entity;

namespace UMS.Data.Interfaces
{
    public interface IDepartmentRepository: IRepository<Department>
    {
        bool Delete(int id);
    }
}
