using System;
using System.Collections.Generic;
using UMS.Core.Interfaces;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Core
{
    public class OrdersService : DomainService<Orders>, IOrdersService
    {
        public bool Delete(int id)
        {
            return ((IOrdersRepository)base.repository).Delete(id);
        }

        public IEnumerable<Orders> GetWithInvoice(int id)
        {
            return ((IOrdersRepository)base.repository).GetWithInvoice(id);
        }

        public int CreateInvoice(int status, int totalPrice)
        {
            return ((IOrdersRepository)base.repository).CreateInvoice(status,totalPrice);
        }




    }
}
