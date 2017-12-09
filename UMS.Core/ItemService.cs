using System;
using System.Collections.Generic;
using UMS.Core.Interfaces;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Core
{
    public class ItemService : DomainService<Item>, IItemService
    {
        public bool Delete(int id)
        {
            return ((IItemRepository)base.repository).Delete(id);
        }

        public IEnumerable<Item> GetAllWithPromo()
        {
            return ((IItemRepository)base.repository).GetAllWithPromo();
        }

        public bool RemovePromo(Item item)
        {
            return ((IItemRepository)base.repository).RemovePromo(item);
        }

        public bool AddPromo(Item item, int promoId)
        {
            return ((IItemRepository)base.repository).AddPromo(item,promoId);
        }


    }
}
