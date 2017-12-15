using System.Collections.Generic;
using System.Runtime.InteropServices;
using UMS.Entity;

namespace UMS.Core.Interfaces
{
    public interface IItemService: IDomainService<Item>
    {
        bool Delete(int id);
        IEnumerable<Item> GetAllWithPromo();
        IEnumerable<Item> GetAllWithPromoByCatId(int id);
        Item GetAllWithPromoById(int id);
        bool RemovePromo(Item item);
        bool AddPromo(Item item, int promoId);
        
    }
}
