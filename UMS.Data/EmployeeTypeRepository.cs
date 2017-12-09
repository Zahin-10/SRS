using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class EmployeeTypeRepository : Repository<EmployeeType>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            EmployeeType employeetype = base.context.EmployeeType.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.EmployeeType.Remove(employeetype);

            return base.context.SaveChanges()>0;
        }   


    }
}
