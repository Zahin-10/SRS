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
        public int CreateInvoice(int status, int totalPrice)
        {
            Invoice newinvoice = new Invoice();
            newinvoice.status = 1;
            newinvoice.totalPrice = totalPrice;
            newinvoice.uid = "1";
            newinvoice.promoId = null;
            base.context.Entry(newinvoice).State = EntityState.Added;

            base.context.SaveChanges();
            int id = newinvoice.Id;
            return id;
        }

        



    }
}
