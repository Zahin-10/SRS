using System.Collections.Generic;
using UMS.Entity;

namespace UMS.Data.Interfaces
{
    public interface IItemRepository: IRepository<Item>
    {
        bool Delete(int id);
        IEnumerable<Item> GetAllWithPromo();
        IEnumerable<Item> GetAllWithPromoByCatId(int id);
        Item GetAllWithPromoById(int id);
        bool RemovePromo(Item item);
        bool AddPromo(Item item, int promoId);
        
    }
}
