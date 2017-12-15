using System;
using System.Collections.Generic;
using UMS.Core.Interfaces;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Core
{
    public class InvoiceService : DomainService<Invoice>
    {
        public bool Delete(int id)
        {
            return ((IInvoiceRepository)base.repository).Delete(id);
        }

        

        




    }
}
