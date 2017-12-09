using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        bool Delete(int id);

        IEnumerable<Customer> GetAllWithPromo();
        Customer GetWithPromo(string id);

        bool RemovePromo(Customer customer);

        bool AddPromo(Customer customer, int promoId);


    }
}
