using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class EmployeeRepository : Repository<Employee>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            Employee employee = base.context.Employee.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.Employee.Remove(employee);

            return base.context.SaveChanges()>0;
        }

        public IEnumerable<Employee> GetAllWithPromo()
        {
            return base.context.Employee.Include(s => s.Promotion).ToList();
        }

        public Employee GetWithPromo(string id)
        {
            return base.context.Employee.Include(s => s.Promotion).SingleOrDefault(s => s.username == id);
        }

        public bool RemovePromo(Employee employee)
        {
            Employee employeeToUpdate = base.context.Employee.SingleOrDefault(s => s.username == employee.username);
            employeeToUpdate.promoId = null;
            base.context.Entry(employeeToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }
        public bool AddPromo(Employee employee, int promoId)
        {
            Employee employeeToUpdate = base.context.Employee.SingleOrDefault(s => s.username == employee.username);
            employeeToUpdate.promoId = promoId;
            base.context.Entry(employeeToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }


    }
}
