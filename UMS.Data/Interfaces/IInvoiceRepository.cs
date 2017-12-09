using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data.Interfaces
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        bool Delete(int id);
        IEnumerable<Invoice> GetWithUser(string id);



    }
}
