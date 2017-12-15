using System;
using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace UMS.Data
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public bool Delete(int Id)
        {
            //Fetching Item
            Item item = base.context.Item.SingleOrDefault(s => s.Id == Id);

            //Now deleting the entity
            base.context.Item.Remove(item);

            return base.context.SaveChanges()>0;
        }

        public IEnumerable<Item> GetAllWithPromo()
        {
             return base.context.Item.Include(s => s.Promotion).Include(s => s.Category).ToList();
        }
        public Item GetAllWithPromoById(int id)
        {
            return base.context.Item.Include(s => s.Promotion).Include(s => s.Category).SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<Item> GetAllWithPromoByCatId(int id)
        {
            return base.context.Item.Include(s => s.Promotion).Include(s => s.Category).Where(s=>s.CategoryId == id).ToList();
        }


        public bool RemovePromo(Item item)
        {
            Item itemToUpdate = base.context.Item.SingleOrDefault(s => s.Id == item.Id);
            itemToUpdate.PromoId = null;
            base.context.Entry(itemToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }
        public bool AddPromo(Item item, int promoId)
        {
            Item itemToUpdate = base.context.Item.SingleOrDefault(s => s.Id == item.Id);
            itemToUpdate.PromoId = promoId;
            base.context.Entry(itemToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }





    }
}
