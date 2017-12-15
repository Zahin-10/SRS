using System.Collections.Generic;
using System.Runtime.InteropServices;
using UMS.Entity;

namespace UMS.Core.Interfaces
{
    public interface IInvoiceService: IDomainService<Invoice>
    {
        bool Delete(int id);
        IEnumerable<Invoice> GetWithUser(string id);

    }
}
