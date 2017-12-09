using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class InvoiceRepository : Repository<Invoice>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            Invoice invoice = base.context.Invoice.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.Invoice.Remove(invoice);

            return base.context.SaveChanges()>0;
        }

        public IEnumerable<Invoice> GetWithUser(string id)
        {
            return base.context.Invoice.Where(s => s.uid == id).ToList();
        }



    }
}
