using System.Collections.Generic;
using System.Runtime.InteropServices;
using UMS.Entity;

namespace UMS.Core.Interfaces
{
    public interface IOrdersService: IDomainService<Orders>
    {
        bool Delete(int id);
        IEnumerable<Orders> GetWithInvoice(int id);
        int CreateInvoice(int status, int totalPrice);

    }
}
