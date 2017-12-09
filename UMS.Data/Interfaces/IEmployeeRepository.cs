using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        bool Delete(int id);
        IEnumerable<Employee> GetAllWithPromo();
        Employee GetWithPromo(string id);

        bool RemovePromo(Employee employee);
        bool AddPromo(Employee employee, int promoId);
    }
}
