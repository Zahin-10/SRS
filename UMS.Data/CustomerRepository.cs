using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class CustomerRepository : Repository<Customer>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            Customer customer = base.context.Customer.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.Customer.Remove(customer);

            return base.context.SaveChanges()>0;
        }

        public IEnumerable<Customer> GetAllWithPromo()
        {
            return base.context.Customer.Include(s => s.Promotion).ToList();
        }

        public Customer GetWithPromo(string id)
        {
            return base.context.Customer.Include(s => s.Promotion).SingleOrDefault(s => s.username == id);
        }

        public bool RemovePromo(Customer customer)
        {
            Customer customerToUpdate = base.context.Customer.SingleOrDefault(s => s.username == customer.username);
            customerToUpdate.promoId = null;
            base.context.Entry(customerToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }
        public bool AddPromo(Customer customer, int promoId)
        {
            Customer customerToUpdate = base.context.Customer.SingleOrDefault(s => s.username == customer.username);
            customerToUpdate.promoId = promoId;
            base.context.Entry(customerToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }


    }
}
