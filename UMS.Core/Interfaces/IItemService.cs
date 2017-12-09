using System.Collections.Generic;
using System.Runtime.InteropServices;
using UMS.Entity;

namespace UMS.Core.Interfaces
{
    public interface IItemService: IDomainService<Item>
    {
        bool Delete(int id);
        IEnumerable<Item> GetAllWithPromo();
        bool RemovePromo(Item item);
        bool AddPromo(Item item, int promoId);
        
    }
}
