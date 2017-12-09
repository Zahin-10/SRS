using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class OrdersRepository : Repository<Orders>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            Orders orders = base.context.Orders.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.Orders.Remove(orders);

            return base.context.SaveChanges()>0;
        }
        public IEnumerable<Orders> GetWithInvoice(int id)
        {
            return base.context.Orders.Include(s => s.invoiceid).Where(s => s.invoiceid == id).ToList();
        }




    }
}
